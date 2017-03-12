namespace robotskaRuka
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelServo1 = new System.Windows.Forms.Label();
            this.txtServoPos1 = new System.Windows.Forms.TextBox();
            this.txtServoPos2 = new System.Windows.Forms.TextBox();
            this.labelServo2 = new System.Windows.Forms.Label();
            this.btnServo3 = new System.Windows.Forms.Button();
            this.txtServoPos3 = new System.Windows.Forms.TextBox();
            this.labelServo3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.scrollServo1 = new System.Windows.Forms.HScrollBar();
            this.scrollServo2 = new System.Windows.Forms.HScrollBar();
            this.scrollServo3 = new System.Windows.Forms.HScrollBar();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnLedOn = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnServo2 = new System.Windows.Forms.Button();
            this.btnServo1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.brnServo4 = new System.Windows.Forms.Button();
            this.scrollServo4 = new System.Windows.Forms.HScrollBar();
            this.txtServoPos4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPosaljiSve = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.servo4Vise = new System.Windows.Forms.Button();
            this.servo4Manje = new System.Windows.Forms.Button();
            this.picLedOn = new System.Windows.Forms.PictureBox();
            this.picLedOff = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.servo3Vise = new System.Windows.Forms.Button();
            this.servo3Manje = new System.Windows.Forms.Button();
            this.servo2Vise = new System.Windows.Forms.Button();
            this.servo2Manje = new System.Windows.Forms.Button();
            this.servo1Vise = new System.Windows.Forms.Button();
            this.servo1Manje = new System.Windows.Forms.Button();
            this.txtTestBytes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLedOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLedOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelServo1
            // 
            this.labelServo1.AutoSize = true;
            this.labelServo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServo1.Location = new System.Drawing.Point(22, 81);
            this.labelServo1.Name = "labelServo1";
            this.labelServo1.Size = new System.Drawing.Size(52, 13);
            this.labelServo1.TabIndex = 2;
            this.labelServo1.Text = "Hvataljka";
            // 
            // txtServoPos1
            // 
            this.txtServoPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtServoPos1.Location = new System.Drawing.Point(185, 104);
            this.txtServoPos1.Name = "txtServoPos1";
            this.txtServoPos1.Size = new System.Drawing.Size(101, 47);
            this.txtServoPos1.TabIndex = 3;
            this.txtServoPos1.TextChanged += new System.EventHandler(this.txtServoPos1_TextChanged);
            // 
            // txtServoPos2
            // 
            this.txtServoPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtServoPos2.Location = new System.Drawing.Point(185, 185);
            this.txtServoPos2.Name = "txtServoPos2";
            this.txtServoPos2.Size = new System.Drawing.Size(101, 47);
            this.txtServoPos2.TabIndex = 8;
            this.txtServoPos2.TextChanged += new System.EventHandler(this.txtServoPos2_TextChanged);
            // 
            // labelServo2
            // 
            this.labelServo2.AutoSize = true;
            this.labelServo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServo2.Location = new System.Drawing.Point(22, 162);
            this.labelServo2.Name = "labelServo2";
            this.labelServo2.Size = new System.Drawing.Size(34, 13);
            this.labelServo2.TabIndex = 7;
            this.labelServo2.Text = "Lakat";
            // 
            // btnServo3
            // 
            this.btnServo3.Location = new System.Drawing.Point(289, 269);
            this.btnServo3.Name = "btnServo3";
            this.btnServo3.Size = new System.Drawing.Size(77, 47);
            this.btnServo3.TabIndex = 14;
            this.btnServo3.Text = "Pošalji";
            this.btnServo3.UseVisualStyleBackColor = true;
            this.btnServo3.Click += new System.EventHandler(this.btnServo3_Click);
            // 
            // txtServoPos3
            // 
            this.txtServoPos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtServoPos3.Location = new System.Drawing.Point(185, 269);
            this.txtServoPos3.Name = "txtServoPos3";
            this.txtServoPos3.Size = new System.Drawing.Size(101, 47);
            this.txtServoPos3.TabIndex = 13;
            this.txtServoPos3.TextChanged += new System.EventHandler(this.txtServoPos3_TextChanged);
            // 
            // labelServo3
            // 
            this.labelServo3.AutoSize = true;
            this.labelServo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServo3.Location = new System.Drawing.Point(22, 247);
            this.labelServo3.Name = "labelServo3";
            this.labelServo3.Size = new System.Drawing.Size(35, 13);
            this.labelServo3.TabIndex = 12;
            this.labelServo3.Text = "Rame";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "Pošalji niz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scrollServo1
            // 
            this.scrollServo1.Location = new System.Drawing.Point(79, 77);
            this.scrollServo1.Maximum = 89;
            this.scrollServo1.Minimum = 15;
            this.scrollServo1.Name = "scrollServo1";
            this.scrollServo1.Size = new System.Drawing.Size(287, 17);
            this.scrollServo1.SmallChange = 5;
            this.scrollServo1.TabIndex = 20;
            this.scrollServo1.Value = 80;
            this.scrollServo1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollServo1_Scroll);
            // 
            // scrollServo2
            // 
            this.scrollServo2.Location = new System.Drawing.Point(79, 158);
            this.scrollServo2.Maximum = 184;
            this.scrollServo2.Minimum = 5;
            this.scrollServo2.Name = "scrollServo2";
            this.scrollServo2.Size = new System.Drawing.Size(287, 17);
            this.scrollServo2.SmallChange = 5;
            this.scrollServo2.TabIndex = 21;
            this.scrollServo2.Value = 90;
            this.scrollServo2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollServo2_Scroll);
            // 
            // scrollServo3
            // 
            this.scrollServo3.Location = new System.Drawing.Point(79, 243);
            this.scrollServo3.Maximum = 184;
            this.scrollServo3.Minimum = 5;
            this.scrollServo3.Name = "scrollServo3";
            this.scrollServo3.Size = new System.Drawing.Size(287, 17);
            this.scrollServo3.SmallChange = 5;
            this.scrollServo3.TabIndex = 22;
            this.scrollServo3.Value = 90;
            this.scrollServo3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollServo3_Scroll);
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
            this.cmbPort.Location = new System.Drawing.Point(382, 73);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(65, 21);
            this.cmbPort.Sorted = true;
            this.cmbPort.TabIndex = 26;
            this.cmbPort.Text = "COM1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmbBaudRate
            // 
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
            this.cmbBaudRate.Location = new System.Drawing.Point(382, 104);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cmbBaudRate.TabIndex = 29;
            this.cmbBaudRate.Text = "9600";
            // 
            // btnLedOn
            // 
            this.btnLedOn.Location = new System.Drawing.Point(379, 200);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(68, 25);
            this.btnLedOn.TabIndex = 31;
            this.btnLedOn.Text = "Led ON";
            this.btnLedOn.UseVisualStyleBackColor = true;
            this.btnLedOn.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.Location = new System.Drawing.Point(379, 231);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(68, 25);
            this.btnLedOff.TabIndex = 32;
            this.btnLedOff.Text = "Led OFF";
            this.btnLedOff.UseVisualStyleBackColor = true;
            this.btnLedOff.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(379, 132);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(68, 62);
            this.btnAuto.TabIndex = 36;
            this.btnAuto.Text = "Pronađi Arduino";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnServo2
            // 
            this.btnServo2.Location = new System.Drawing.Point(289, 185);
            this.btnServo2.Name = "btnServo2";
            this.btnServo2.Size = new System.Drawing.Size(77, 47);
            this.btnServo2.TabIndex = 37;
            this.btnServo2.Text = "Pošalji";
            this.btnServo2.UseVisualStyleBackColor = true;
            this.btnServo2.Click += new System.EventHandler(this.btnServo2_Click);
            // 
            // btnServo1
            // 
            this.btnServo1.Location = new System.Drawing.Point(289, 104);
            this.btnServo1.Name = "btnServo1";
            this.btnServo1.Size = new System.Drawing.Size(77, 47);
            this.btnServo1.TabIndex = 38;
            this.btnServo1.Text = "Pošalji";
            this.btnServo1.UseVisualStyleBackColor = true;
            this.btnServo1.Click += new System.EventHandler(this.btnServo1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(25, 49);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(422, 20);
            this.txtStatus.TabIndex = 46;
            // 
            // brnServo4
            // 
            this.brnServo4.Location = new System.Drawing.Point(289, 353);
            this.brnServo4.Name = "brnServo4";
            this.brnServo4.Size = new System.Drawing.Size(77, 47);
            this.brnServo4.TabIndex = 61;
            this.brnServo4.Text = "Pošalji";
            this.brnServo4.UseVisualStyleBackColor = true;
            this.brnServo4.Click += new System.EventHandler(this.brnServo4_Click);
            // 
            // scrollServo4
            // 
            this.scrollServo4.Location = new System.Drawing.Point(79, 326);
            this.scrollServo4.Maximum = 184;
            this.scrollServo4.Minimum = 5;
            this.scrollServo4.Name = "scrollServo4";
            this.scrollServo4.Size = new System.Drawing.Size(287, 17);
            this.scrollServo4.SmallChange = 5;
            this.scrollServo4.TabIndex = 59;
            this.scrollServo4.Value = 90;
            this.scrollServo4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollServo4_Scroll);
            // 
            // txtServoPos4
            // 
            this.txtServoPos4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtServoPos4.Location = new System.Drawing.Point(185, 353);
            this.txtServoPos4.Name = "txtServoPos4";
            this.txtServoPos4.Size = new System.Drawing.Size(101, 47);
            this.txtServoPos4.TabIndex = 58;
            this.txtServoPos4.TextChanged += new System.EventHandler(this.txtServoPos4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Baza";
            // 
            // btnPosaljiSve
            // 
            this.btnPosaljiSve.Location = new System.Drawing.Point(379, 326);
            this.btnPosaljiSve.Name = "btnPosaljiSve";
            this.btnPosaljiSve.Size = new System.Drawing.Size(68, 74);
            this.btnPosaljiSve.TabIndex = 62;
            this.btnPosaljiSve.Text = "Pošalji sve";
            this.btnPosaljiSve.UseVisualStyleBackColor = true;
            this.btnPosaljiSve.Click += new System.EventHandler(this.btnPosaljiSve_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.BackgroundImage = global::robotskaRuka.Properties.Resources.servo_color_512;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ErrorImage = global::robotskaRuka.Properties.Resources.Servo_01_512;
            this.pictureBox4.Location = new System.Drawing.Point(25, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // servo4Vise
            // 
            this.servo4Vise.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo4Vise.BackgroundImage = global::robotskaRuka.Properties.Resources.desno;
            this.servo4Vise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo4Vise.Location = new System.Drawing.Point(132, 353);
            this.servo4Vise.Name = "servo4Vise";
            this.servo4Vise.Size = new System.Drawing.Size(47, 47);
            this.servo4Vise.TabIndex = 56;
            this.servo4Vise.UseVisualStyleBackColor = false;
            this.servo4Vise.Click += new System.EventHandler(this.servo4Vise_Click);
            // 
            // servo4Manje
            // 
            this.servo4Manje.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo4Manje.BackgroundImage = global::robotskaRuka.Properties.Resources.lijevo1;
            this.servo4Manje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo4Manje.Location = new System.Drawing.Point(79, 353);
            this.servo4Manje.Name = "servo4Manje";
            this.servo4Manje.Size = new System.Drawing.Size(47, 47);
            this.servo4Manje.TabIndex = 55;
            this.servo4Manje.UseVisualStyleBackColor = false;
            this.servo4Manje.Click += new System.EventHandler(this.servo4Manje_Click);
            // 
            // picLedOn
            // 
            this.picLedOn.BackgroundImage = global::robotskaRuka.Properties.Resources.zelenaLed;
            this.picLedOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLedOn.Location = new System.Drawing.Point(379, 269);
            this.picLedOn.Name = "picLedOn";
            this.picLedOn.Size = new System.Drawing.Size(68, 47);
            this.picLedOn.TabIndex = 42;
            this.picLedOn.TabStop = false;
            this.picLedOn.Visible = false;
            // 
            // picLedOff
            // 
            this.picLedOff.BackgroundImage = global::robotskaRuka.Properties.Resources.crvenaLed;
            this.picLedOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLedOff.Location = new System.Drawing.Point(379, 269);
            this.picLedOff.Name = "picLedOff";
            this.picLedOff.Size = new System.Drawing.Size(68, 47);
            this.picLedOff.TabIndex = 41;
            this.picLedOff.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.BackgroundImage = global::robotskaRuka.Properties.Resources.servo_color_512;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = global::robotskaRuka.Properties.Resources.Servo_01_512;
            this.pictureBox3.Location = new System.Drawing.Point(25, 269);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 47);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BackgroundImage = global::robotskaRuka.Properties.Resources.servo_color_512;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = global::robotskaRuka.Properties.Resources.Servo_01_512;
            this.pictureBox2.Location = new System.Drawing.Point(25, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = global::robotskaRuka.Properties.Resources.servo_color_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::robotskaRuka.Properties.Resources.Servo_01_512;
            this.pictureBox1.Location = new System.Drawing.Point(25, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // servo3Vise
            // 
            this.servo3Vise.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo3Vise.BackgroundImage = global::robotskaRuka.Properties.Resources.desno;
            this.servo3Vise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo3Vise.Location = new System.Drawing.Point(132, 269);
            this.servo3Vise.Name = "servo3Vise";
            this.servo3Vise.Size = new System.Drawing.Size(47, 47);
            this.servo3Vise.TabIndex = 11;
            this.servo3Vise.UseVisualStyleBackColor = false;
            this.servo3Vise.Click += new System.EventHandler(this.servo3Vise_Click);
            // 
            // servo3Manje
            // 
            this.servo3Manje.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo3Manje.BackgroundImage = global::robotskaRuka.Properties.Resources.lijevo1;
            this.servo3Manje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo3Manje.Location = new System.Drawing.Point(79, 269);
            this.servo3Manje.Name = "servo3Manje";
            this.servo3Manje.Size = new System.Drawing.Size(47, 47);
            this.servo3Manje.TabIndex = 10;
            this.servo3Manje.UseVisualStyleBackColor = false;
            this.servo3Manje.Click += new System.EventHandler(this.servo3Manje_Click);
            // 
            // servo2Vise
            // 
            this.servo2Vise.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo2Vise.BackgroundImage = global::robotskaRuka.Properties.Resources.desno;
            this.servo2Vise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo2Vise.Location = new System.Drawing.Point(132, 185);
            this.servo2Vise.Name = "servo2Vise";
            this.servo2Vise.Size = new System.Drawing.Size(47, 47);
            this.servo2Vise.TabIndex = 6;
            this.servo2Vise.UseVisualStyleBackColor = false;
            this.servo2Vise.Click += new System.EventHandler(this.servo2Vise_Click);
            // 
            // servo2Manje
            // 
            this.servo2Manje.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo2Manje.BackgroundImage = global::robotskaRuka.Properties.Resources.lijevo1;
            this.servo2Manje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo2Manje.Location = new System.Drawing.Point(79, 185);
            this.servo2Manje.Name = "servo2Manje";
            this.servo2Manje.Size = new System.Drawing.Size(47, 47);
            this.servo2Manje.TabIndex = 5;
            this.servo2Manje.UseVisualStyleBackColor = false;
            this.servo2Manje.Click += new System.EventHandler(this.servo2Manje_Click);
            // 
            // servo1Vise
            // 
            this.servo1Vise.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo1Vise.BackgroundImage = global::robotskaRuka.Properties.Resources.desno;
            this.servo1Vise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo1Vise.Location = new System.Drawing.Point(132, 104);
            this.servo1Vise.Name = "servo1Vise";
            this.servo1Vise.Size = new System.Drawing.Size(47, 47);
            this.servo1Vise.TabIndex = 1;
            this.servo1Vise.UseVisualStyleBackColor = false;
            this.servo1Vise.Click += new System.EventHandler(this.servo1Vise_Click);
            // 
            // servo1Manje
            // 
            this.servo1Manje.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo1Manje.BackgroundImage = global::robotskaRuka.Properties.Resources.lijevo1;
            this.servo1Manje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo1Manje.Location = new System.Drawing.Point(79, 104);
            this.servo1Manje.Name = "servo1Manje";
            this.servo1Manje.Size = new System.Drawing.Size(47, 47);
            this.servo1Manje.TabIndex = 0;
            this.servo1Manje.UseVisualStyleBackColor = false;
            this.servo1Manje.Click += new System.EventHandler(this.servo1Manje_Click);
            // 
            // txtTestBytes
            // 
            this.txtTestBytes.Location = new System.Drawing.Point(28, 425);
            this.txtTestBytes.Name = "txtTestBytes";
            this.txtTestBytes.Size = new System.Drawing.Size(100, 20);
            this.txtTestBytes.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 480);
            this.Controls.Add(this.txtTestBytes);
            this.Controls.Add(this.btnPosaljiSve);
            this.Controls.Add(this.brnServo4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.scrollServo4);
            this.Controls.Add(this.txtServoPos4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.servo4Vise);
            this.Controls.Add(this.servo4Manje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.picLedOn);
            this.Controls.Add(this.picLedOff);
            this.Controls.Add(this.btnServo1);
            this.Controls.Add(this.btnServo2);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnLedOff);
            this.Controls.Add(this.btnLedOn);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scrollServo3);
            this.Controls.Add(this.scrollServo2);
            this.Controls.Add(this.scrollServo1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnServo3);
            this.Controls.Add(this.txtServoPos3);
            this.Controls.Add(this.labelServo3);
            this.Controls.Add(this.servo3Vise);
            this.Controls.Add(this.servo3Manje);
            this.Controls.Add(this.txtServoPos2);
            this.Controls.Add(this.labelServo2);
            this.Controls.Add(this.servo2Vise);
            this.Controls.Add(this.servo2Manje);
            this.Controls.Add(this.txtServoPos1);
            this.Controls.Add(this.labelServo1);
            this.Controls.Add(this.servo1Vise);
            this.Controls.Add(this.servo1Manje);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Robotska ruka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLedOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLedOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button servo1Manje;
        private System.Windows.Forms.Button servo1Vise;
        private System.Windows.Forms.Label labelServo1;
        private System.Windows.Forms.TextBox txtServoPos1;
        private System.Windows.Forms.TextBox txtServoPos2;
        private System.Windows.Forms.Label labelServo2;
        private System.Windows.Forms.Button servo2Vise;
        private System.Windows.Forms.Button servo2Manje;
        private System.Windows.Forms.Button btnServo3;
        private System.Windows.Forms.TextBox txtServoPos3;
        private System.Windows.Forms.Label labelServo3;
        private System.Windows.Forms.Button servo3Vise;
        private System.Windows.Forms.Button servo3Manje;
        private System.Windows.Forms.Button button2;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.HScrollBar scrollServo1;
        private System.Windows.Forms.HScrollBar scrollServo2;
        private System.Windows.Forms.HScrollBar scrollServo3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnServo2;
        private System.Windows.Forms.Button btnServo1;
        private System.Windows.Forms.PictureBox picLedOff;
        private System.Windows.Forms.PictureBox picLedOn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button brnServo4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.HScrollBar scrollServo4;
        private System.Windows.Forms.TextBox txtServoPos4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button servo4Vise;
        private System.Windows.Forms.Button servo4Manje;
        private System.Windows.Forms.Button btnPosaljiSve;
        private System.Windows.Forms.TextBox txtTestBytes;
    }
}

