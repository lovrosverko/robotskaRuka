namespace robotskaRuka
{
    partial class probnaForma
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
            this.btnCitaj = new System.Windows.Forms.Button();
            this.btnPisi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCitaj
            // 
            this.btnCitaj.Location = new System.Drawing.Point(432, 103);
            this.btnCitaj.Name = "btnCitaj";
            this.btnCitaj.Size = new System.Drawing.Size(75, 23);
            this.btnCitaj.TabIndex = 0;
            this.btnCitaj.Text = "Čitaj";
            this.btnCitaj.UseVisualStyleBackColor = true;
            // 
            // btnPisi
            // 
            this.btnPisi.Location = new System.Drawing.Point(432, 74);
            this.btnPisi.Name = "btnPisi";
            this.btnPisi.Size = new System.Drawing.Size(75, 23);
            this.btnPisi.TabIndex = 1;
            this.btnPisi.Text = "Piši";
            this.btnPisi.UseVisualStyleBackColor = true;
            this.btnPisi.Click += new System.EventHandler(this.btnPisi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 289);
            this.textBox1.TabIndex = 2;
            // 
            // probnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPisi);
            this.Controls.Add(this.btnCitaj);
            this.Name = "probnaForma";
            this.Text = "probnaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCitaj;
        private System.Windows.Forms.Button btnPisi;
        private System.Windows.Forms.TextBox textBox1;
    }
}