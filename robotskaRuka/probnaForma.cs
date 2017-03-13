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

        private void btnPisi_Click(object sender, EventArgs e)
        {
            string zapis = BitConverter.ToString(polje);
            File.WriteAllText("testIO.txt", zapis);
        }
    }
}
