using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IFACI_INTERFACE_MULTIFUNCAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string[] portas = SerialPort.GetPortNames();
           comboBoxPortas.Items.AddRange(portas);
        }

        private void lerDados(object sender, EventArgs e)
        {
            string dadosBrutos = serialPort1.ReadExisting();

            if (dadosBrutos != "")
            {
                string[] dados = dadosBrutos.Split(',');
                float ajuste = (float.Parse(dados[0])*100) / 1023;
                float temp = float.Parse(dados[1]);

                aGAjuste.Value = ajuste;
                aGTemp.Value = temp;
                pictureBox6.Visible = false;
                pictureBox3.Visible = true;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerDados));
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            if (serialPort1 == null || !serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBoxPortas.SelectedItem.ToString();
                serialPort1.Open();
            }
        }
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            Application.Exit();
        }
    }
}
