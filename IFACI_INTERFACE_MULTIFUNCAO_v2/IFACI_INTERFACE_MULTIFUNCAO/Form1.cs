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
using System.Diagnostics;

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
            if (!string.IsNullOrEmpty(dadosBrutos))
            {
                string[] dados = dadosBrutos.Split(',');
                if (dados.Length >= 2)
                {
                    if (float.TryParse(dados[0], out float valor) &&
                        float.TryParse(dados[1], out float temp))
                    {
                        if (valor > 0)
                        {
                            float ajuste = (valor * 100) / 1023;
                            aGAjuste.Value = ajuste;
                        }
                        else
                        {
                            aGAjuste.Value = 0;
                        }
                        if (temp > 0)
                        {
                            aGTemp.Value = temp;
                        }
                        else
                        {
                            aGTemp.Value = 0;
                        }

                    }
                    else
                    {
                        Debug.WriteLine("Dados recebidos em formato inválido");
                    }
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerDados));
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            if (comboBoxPortas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma porta COM");
                return;
            }

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

        private void btLigarLED_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serialPort1.WriteLine("1");
                pictureBox6.Visible = true;
                pictureBox3.Visible = false;

            }

        }

        private void btDesligarLED_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serialPort1.WriteLine("0");
                pictureBox6.Visible = false;
                pictureBox3.Visible = true;

            }
        }
    }
}
