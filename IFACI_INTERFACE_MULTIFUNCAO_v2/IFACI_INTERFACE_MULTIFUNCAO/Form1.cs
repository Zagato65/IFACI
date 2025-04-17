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
        private String dadosBrutos = "";
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
            dadosBrutos = serialPort1.ReadExisting();
            //Console.Write(dadosBrutos);
            if (dadosBrutos != "")
            {
                string[] dados = dadosBrutos.Split(',');
                float ajuste = float.Parse(dados[0]);
                Console.Write(dados[0]);
                double temp = double.Parse(dados[1]);

                aGAjuste.Value = ajuste;
                //aGTemp.Value = temp;
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
