namespace IFACI_INTERFACE_MULTIFUNCAO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange7 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange8 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel4 = new System.Windows.Forms.AGaugeLabel();
            this.aGTemp = new System.Windows.Forms.AGauge();
            this.aGAjuste = new System.Windows.Forms.AGauge();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aGTemp
            // 
            this.aGTemp.BaseArcColor = System.Drawing.Color.Gray;
            this.aGTemp.BaseArcRadius = 80;
            this.aGTemp.BaseArcStart = 135;
            this.aGTemp.BaseArcSweep = 270;
            this.aGTemp.BaseArcWidth = 2;
            this.aGTemp.Center = new System.Drawing.Point(105, 105);
            aGaugeLabel3.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel3.Name = "GaugeLabel1";
            aGaugeLabel3.Position = new System.Drawing.Point(70, 150);
            aGaugeLabel3.Text = "Temperatura";
            this.aGTemp.GaugeLabels.Add(aGaugeLabel3);
            aGaugeRange5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            aGaugeRange5.EndValue = 30F;
            aGaugeRange5.InnerRadius = 50;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRangeNormal";
            aGaugeRange5.OuterRadius = 80;
            aGaugeRange5.StartValue = 0F;
            aGaugeRange6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange6.EndValue = 60F;
            aGaugeRange6.InnerRadius = 50;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRangeAtencao";
            aGaugeRange6.OuterRadius = 80;
            aGaugeRange6.StartValue = 30F;
            aGaugeRange7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            aGaugeRange7.EndValue = 90F;
            aGaugeRange7.InnerRadius = 50;
            aGaugeRange7.InRange = false;
            aGaugeRange7.Name = "GaugeRangeAlerta1";
            aGaugeRange7.OuterRadius = 80;
            aGaugeRange7.StartValue = 60F;
            aGaugeRange8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            aGaugeRange8.EndValue = 120F;
            aGaugeRange8.InnerRadius = 50;
            aGaugeRange8.InRange = false;
            aGaugeRange8.Name = "GaugeRangeAlerta2";
            aGaugeRange8.OuterRadius = 80;
            aGaugeRange8.StartValue = 90F;
            this.aGTemp.GaugeRanges.Add(aGaugeRange5);
            this.aGTemp.GaugeRanges.Add(aGaugeRange6);
            this.aGTemp.GaugeRanges.Add(aGaugeRange7);
            this.aGTemp.GaugeRanges.Add(aGaugeRange8);
            this.aGTemp.Location = new System.Drawing.Point(28, 10);
            this.aGTemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aGTemp.MaxValue = 120F;
            this.aGTemp.MinValue = 0F;
            this.aGTemp.Name = "aGTemp";
            this.aGTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGTemp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGTemp.NeedleRadius = 80;
            this.aGTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGTemp.NeedleWidth = 2;
            this.aGTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGTemp.ScaleLinesInterInnerRadius = 73;
            this.aGTemp.ScaleLinesInterOuterRadius = 80;
            this.aGTemp.ScaleLinesInterWidth = 1;
            this.aGTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGTemp.ScaleLinesMajorInnerRadius = 70;
            this.aGTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGTemp.ScaleLinesMajorStepValue = 10F;
            this.aGTemp.ScaleLinesMajorWidth = 2;
            this.aGTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGTemp.ScaleLinesMinorInnerRadius = 75;
            this.aGTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGTemp.ScaleLinesMinorTicks = 9;
            this.aGTemp.ScaleLinesMinorWidth = 1;
            this.aGTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGTemp.ScaleNumbersFormat = null;
            this.aGTemp.ScaleNumbersRadius = 95;
            this.aGTemp.ScaleNumbersRotation = 0;
            this.aGTemp.ScaleNumbersStartScaleLine = 0;
            this.aGTemp.ScaleNumbersStepScaleLines = 1;
            this.aGTemp.Size = new System.Drawing.Size(214, 205);
            this.aGTemp.TabIndex = 0;
            this.aGTemp.Text = "aGauge1";
            this.aGTemp.Value = 0F;
            // 
            // aGAjuste
            // 
            this.aGAjuste.BaseArcColor = System.Drawing.Color.Gray;
            this.aGAjuste.BaseArcRadius = 80;
            this.aGAjuste.BaseArcStart = 135;
            this.aGAjuste.BaseArcSweep = 270;
            this.aGAjuste.BaseArcWidth = 2;
            this.aGAjuste.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel4.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel4.Name = "GaugeLabelAjuste";
            aGaugeLabel4.Position = new System.Drawing.Point(75, 150);
            aGaugeLabel4.Text = "Ajuste (%)";
            this.aGAjuste.GaugeLabels.Add(aGaugeLabel4);
            this.aGAjuste.Location = new System.Drawing.Point(262, 10);
            this.aGAjuste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aGAjuste.MaxValue = 100F;
            this.aGAjuste.MinValue = 0F;
            this.aGAjuste.Name = "aGAjuste";
            this.aGAjuste.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGAjuste.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGAjuste.NeedleRadius = 80;
            this.aGAjuste.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGAjuste.NeedleWidth = 2;
            this.aGAjuste.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGAjuste.ScaleLinesInterInnerRadius = 73;
            this.aGAjuste.ScaleLinesInterOuterRadius = 80;
            this.aGAjuste.ScaleLinesInterWidth = 1;
            this.aGAjuste.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGAjuste.ScaleLinesMajorInnerRadius = 70;
            this.aGAjuste.ScaleLinesMajorOuterRadius = 80;
            this.aGAjuste.ScaleLinesMajorStepValue = 10F;
            this.aGAjuste.ScaleLinesMajorWidth = 2;
            this.aGAjuste.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGAjuste.ScaleLinesMinorInnerRadius = 75;
            this.aGAjuste.ScaleLinesMinorOuterRadius = 80;
            this.aGAjuste.ScaleLinesMinorTicks = 9;
            this.aGAjuste.ScaleLinesMinorWidth = 1;
            this.aGAjuste.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGAjuste.ScaleNumbersFormat = null;
            this.aGAjuste.ScaleNumbersRadius = 95;
            this.aGAjuste.ScaleNumbersRotation = 0;
            this.aGAjuste.ScaleNumbersStartScaleLine = 0;
            this.aGAjuste.ScaleNumbersStepScaleLines = 1;
            this.aGAjuste.Size = new System.Drawing.Size(225, 205);
            this.aGAjuste.TabIndex = 1;
            this.aGAjuste.Text = "aGauge2";
            this.aGAjuste.Value = 0F;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::IFACI_INTERFACE_MULTIFUNCAO.Properties.Resources.led_diode_red;
            this.pictureBox6.Location = new System.Drawing.Point(100, 240);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::IFACI_INTERFACE_MULTIFUNCAO.Properties.Resources.led_diode_yellow;
            this.pictureBox5.Location = new System.Drawing.Point(317, 240);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::IFACI_INTERFACE_MULTIFUNCAO.Properties.Resources.led_diode_gray;
            this.pictureBox4.Location = new System.Drawing.Point(267, 240);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IFACI_INTERFACE_MULTIFUNCAO.Properties.Resources.led_diode_gray;
            this.pictureBox3.Location = new System.Drawing.Point(150, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IFACI_INTERFACE_MULTIFUNCAO.Properties.Resources.led_diode_blue;
            this.pictureBox2.Location = new System.Drawing.Point(28, 378);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IFACI_INTERFACE_MULTIFUNCAO.Properties.Resources.led_diode_gray;
            this.pictureBox1.Location = new System.Drawing.Point(28, 378);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(150, 401);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 8;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btiniciar_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(238, 401);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 9;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(192, 355);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortas.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Porta";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPortas);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aGAjuste);
            this.Controls.Add(this.aGTemp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.AGauge aGTemp;
        private System.Windows.Forms.AGauge aGAjuste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.ComboBox comboBoxPortas;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

