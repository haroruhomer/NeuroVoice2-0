using System;
using System.Windows.Forms;

namespace NeuroVoice2_0
{
    public partial class F_Preferencias : Form
    {
        public F_Preferencias()
        {
            InitializeComponent();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void TB_Capas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void TB_Neuronas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar.Equals(';'))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void F_Preferencias_Load(object sender, EventArgs e)
        {
            TB_Capas.Text = Properties.Settings.Default.Capas.ToString();
            TB_Neuronas.Text = Properties.Settings.Default.Neuronas.ToString();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Capas = int.Parse(TB_Capas.Text);
            Properties.Settings.Default.Neuronas = TB_Neuronas.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
