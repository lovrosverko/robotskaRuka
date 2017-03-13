namespace robotskaRuka
{
    partial class slanje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slanje));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtServo1 = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtServo2 = new System.Windows.Forms.TextBox();
            this.txtServo3 = new System.Windows.Forms.TextBox();
            this.txtServo4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnPosaljiSve = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSaveToTxt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(409, 244);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            // 
            // txtServo1
            // 
            this.txtServo1.Location = new System.Drawing.Point(123, 44);
            this.txtServo1.Name = "txtServo1";
            this.txtServo1.Size = new System.Drawing.Size(55, 20);
            this.txtServo1.TabIndex = 12;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(427, 41);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtServo2
            // 
            this.txtServo2.Location = new System.Drawing.Point(204, 44);
            this.txtServo2.Name = "txtServo2";
            this.txtServo2.Size = new System.Drawing.Size(55, 20);
            this.txtServo2.TabIndex = 13;
            // 
            // txtServo3
            // 
            this.txtServo3.Location = new System.Drawing.Point(285, 43);
            this.txtServo3.Name = "txtServo3";
            this.txtServo3.Size = new System.Drawing.Size(55, 20);
            this.txtServo3.TabIndex = 14;
            // 
            // txtServo4
            // 
            this.txtServo4.Location = new System.Drawing.Point(366, 44);
            this.txtServo4.Name = "txtServo4";
            this.txtServo4.Size = new System.Drawing.Size(55, 20);
            this.txtServo4.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hvataljka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lakat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rame";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Baza";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(427, 252);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 62);
            this.btnAuto.TabIndex = 39;
            this.btnAuto.TabStop = false;
            this.btnAuto.Text = "Pronađi Arduino";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Enabled = false;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.cmbBaudRate.Location = new System.Drawing.Point(427, 225);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(75, 21);
            this.cmbBaudRate.TabIndex = 38;
            this.cmbBaudRate.TabStop = false;
            this.cmbBaudRate.Text = "9600";
            // 
            // cmbPort
            // 
            this.cmbPort.Enabled = false;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cmbPort.Location = new System.Drawing.Point(427, 198);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(75, 21);
            this.cmbPort.Sorted = true;
            this.cmbPort.TabIndex = 37;
            this.cmbPort.TabStop = false;
            this.cmbPort.Text = "COM1";
            // 
            // btnPosaljiSve
            // 
            this.btnPosaljiSve.Location = new System.Drawing.Point(427, 12);
            this.btnPosaljiSve.Name = "btnPosaljiSve";
            this.btnPosaljiSve.Size = new System.Drawing.Size(75, 23);
            this.btnPosaljiSve.TabIndex = 40;
            this.btnPosaljiSve.TabStop = false;
            this.btnPosaljiSve.Text = "Pošalji";
            this.btnPosaljiSve.UseVisualStyleBackColor = true;
            this.btnPosaljiSve.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(427, 70);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 55);
            this.btnObrisi.TabIndex = 41;
            this.btnObrisi.TabStop = false;
            this.btnObrisi.Text = "Provjera spremanja";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSaveToTxt
            // 
            this.btnSaveToTxt.Location = new System.Drawing.Point(427, 131);
            this.btnSaveToTxt.Name = "btnSaveToTxt";
            this.btnSaveToTxt.Size = new System.Drawing.Size(75, 55);
            this.btnSaveToTxt.TabIndex = 42;
            this.btnSaveToTxt.TabStop = false;
            this.btnSaveToTxt.Text = "Spremi u dokument";
            this.btnSaveToTxt.UseVisualStyleBackColor = true;
            this.btnSaveToTxt.Click += new System.EventHandler(this.btnSaveToTxt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::robotskaRuka.Properties.Resources.roboticArm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 50);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // slanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSaveToTxt);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPosaljiSve);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServo4);
            this.Controls.Add(this.txtServo3);
            this.Controls.Add(this.txtServo2);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtServo1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "slanje";
            this.Text = "Slanje 5 pozicija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtServo1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtServo2;
        private System.Windows.Forms.TextBox txtServo3;
        private System.Windows.Forms.TextBox txtServo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnPosaljiSve;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSaveToTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}