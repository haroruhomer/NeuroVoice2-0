using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento
{
    public partial class F_Reconocer : Form
    {
        private SerialPort arduino = new SerialPort();
        public F_Reconocer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Open();
                arduino.Write("A");
                arduino.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void F_Reconocer_Load(object sender, EventArgs e)
        {
            foreach (string item in SerialPort.GetPortNames())
            {
                CB_Puertos.Items.Add(item);
            }
        }

        private void CB_Puertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                arduino.PortName = CB_Puertos.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                arduino.Open();
                arduino.Write("L");
                arduino.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
