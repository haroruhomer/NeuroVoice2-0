using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Accord.Audio;
using Accord.Audio.Formats;
using Accord.Audio.Windows;
using CSCore;
using CSCore.Codecs;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using Neuro.Neurona;

namespace NeuroVoice2_0
{
    public partial class F_Entrenar : Form
    {
        #region
        private int[] estrucRed;
        private Neuronas[] red;
        int capas;
        IAudioSource entradas;
        IWindow ventana;
        WasapiCapture wcp = new WasapiCapture();
        MMDeviceCollection collec;
        WaveWriter audioWriter;
        #endregion

        Random rndm = new Random();

        public F_Entrenar()
        {
            InitializeComponent();
        }

        private void B_Reconocer_Click(object sender, EventArgs e)
        {
            Reconocimiento.F_Reconocer reco = new Reconocimiento.F_Reconocer();
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("Reconocimiento.exe");
            p.StartInfo = psi;
            p.Start();
            this.Close();
        }

        private void Menu_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pref_Menu_Click(object sender, EventArgs e)
        {
            F_Preferencias f = new F_Preferencias();
            //F_Entrenar fe = new F_Entrenar();
            f.ShowDialog(this);
            if (f.DialogResult == DialogResult.OK)
            {
                CargarPref();                
            }
        }

        private void F_Entrenar_Load(object sender, EventArgs e)
        {
            MMDeviceEnumerator enumer =new MMDeviceEnumerator();
            collec = enumer.EnumAudioEndpoints(DataFlow.Capture,DeviceState.Active);
            foreach(MMDevice device in collec)
            {
                CB_Disp.Items.Add(device.FriendlyName);
            }
            CargarPref();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            GV_Audios.Rows.Clear();
            DataTable dt = new DataTable();
            DataRow row;
            dt.Columns.Add("Archivo");
            dt.Columns.Add("letra");
            row = dt.NewRow();
            string[] archivos = System.IO.Directory.GetFiles(Application.StartupPath, "*.wav");

            foreach (string archivo in archivos)
            {
                row[0] = System.IO.Path.GetFileName(archivo);
                char[] letra=System.IO.Path.GetFileName(archivo).ToCharArray();
                row[1] = letra[0];
                GV_Audios.Rows.Add(row[0],row[1]);
            }
        }

        private void CargarPref()
        {
            string[] totalNeurona;
            capas = Properties.Settings.Default.Capas;
            estrucRed = Neuro.Red.Red.CrearRed(capas);
            red = Neuro.Red.Red.CrearNeuronas(capas);

            totalNeurona = Properties.Settings.Default.Neuronas.Split(';');

            if (totalNeurona.Length >= (capas - 2))
            {
                for (int i = 1; i < estrucRed.Length - 1; i++)
                {
                    estrucRed[i] = int.Parse(totalNeurona[i - 1]);
                }
            }
            else
            {
                MessageBox.Show("Revise las configuraciones y asegurese de asignar un numero correcto de neuronas a las capas ocultas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CB_Disp_SelectedIndexChanged(object sender, EventArgs e)
        {
            wcp.Device=collec[CB_Disp.SelectedIndex];
        }

        private void B_Grabar_Click(object sender, EventArgs e)
        {
            if (!(CB_Disp.SelectedIndex == -1 || CB_Letra.SelectedIndex == -1 || TB_Nombre.Text == String.Empty))
            {
                wcp.Initialize();
                wcp.DataAvailable += new EventHandler<DataAvailableEventArgs>(audio_newFrame);
                audioWriter = new WaveWriter(CB_Letra.SelectedItem + TB_Nombre.Text + ".wav", wcp.WaveFormat);
                wcp.Start();
                T_Tiempo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Revise los parametros de grabación");
            }
        }

        private void audio_newFrame(object sender, DataAvailableEventArgs e)
        {
            Console.WriteLine(e.Data[rndm.Next(e.ByteCount)]);
            Console.WriteLine(e.Data[rndm.Next(e.ByteCount)]);
            Console.WriteLine(e.Data[rndm.Next(e.ByteCount)]);
            Console.WriteLine(e.Data[rndm.Next(e.ByteCount)]);
            Console.WriteLine(e.Data[rndm.Next(e.ByteCount)]);
            audioWriter.Write(e.Data, e.Offset, e.ByteCount);
        }

        private void T_Tiempo_Tick(object sender, EventArgs e)
        {
            audioWriter.Dispose();
            wcp.Stop();
            T_Tiempo.Enabled = false;
            GV_Audios.Rows.Clear();
            ActualizarTabla();
        }

        private void GV_Audios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string archivo = GV_Audios.Rows[e.RowIndex].Cells["Archivo"].Value.ToString();
            if (e.ColumnIndex == 3)
            {
                if (File.Exists(archivo))
                {
                    File.Delete(archivo);
                    ActualizarTabla();
                }
                else
                {
                    MessageBox.Show("El archivo ya no existe");
                }
            }

            if (e.ColumnIndex==2)
            {
                if (File.Exists(archivo))
                {
                    try
                    {
                        IWaveSource audioPlay = CodecFactory.Instance.GetCodec(archivo);
                        ISoundOut salidaSonido;
                        if (WasapiOut.IsSupportedOnCurrentPlatform)
                        {
                            salidaSonido = new WasapiOut();
                        }
                        else
                        {
                            salidaSonido = new DirectSoundOut();
                        }
                        salidaSonido.Initialize(audioPlay);
                        salidaSonido.Play();
                        Thread.Sleep(1000);
                        salidaSonido.Stop();
                        salidaSonido.Dispose();
                        audioPlay.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void B_Entrenar_Click(object sender, EventArgs e)
        {
            
            double errorG = 0.0;
            short[,] salida = new short[GV_Audios.Rows.Count, 3];
            Double[,] input = new Double[GV_Audios.Rows.Count, 16];
            Double[,] aux;
            int index = 0;
            Random rndm = new Random();
            double alfa = 0.2, beta = 0.8;
            ventana = RaisedCosineWindow.Hamming(16);
            

            foreach (DataGridViewRow fila in GV_Audios.Rows)
            {
                WaveDecoder audio = new WaveDecoder(fila.Cells[0].Value.ToString());

            }
        }
            
    }
}
