using System;
using System.IO;
using System.Windows.Forms;

namespace robotskaRuka
{
    public partial class probnaForma : Form
    {
        byte[] polje = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

        public probnaForma()
        {
            InitializeComponent();
        }

        // this works
        private void btnPisi_Click(object sender, EventArgs e)
        {
            string zapis = BitConverter.ToString(polje);
            File.WriteAllBytes("testIO.txt", polje);
        }

        // doesn't quite work
        private void btnCitaj_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("testIO.txt", FileMode.Open);
            int hexIn;
            int dec;
            

            for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
            {
                dec = Convert.ToInt16(hexIn);
                textBox1.AppendText(Convert.ToString(dec) + " - ");
            }
           
        }
    }
}
