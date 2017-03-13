using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace robotskaRuka
{
    public partial class slanje : Form
    {
        public slanje()
        {
            InitializeComponent();
            //  btnSaveToTxt.Enabled = false;
            sakrij();
        }
        int brojNaredbe = 0;

        int pozicija = 1;

        SerialPort currentPort;
        bool portFound;

        byte[] naredba = new byte[9999];


        // spremanje kuteva
        public void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtServo1.Text.Length == 0 || txtServo2.Text.Length == 0 || txtServo3.Text.Length == 0 || txtServo4.Text.Length == 0)
            {
                MessageBox.Show("Upiši kut.");
            }
            else if (Convert.ToInt32(txtServo1.Text) > 175 || Convert.ToInt32(txtServo2.Text) > 175 || Convert.ToInt32(txtServo3.Text) > 175 || Convert.ToInt32(txtServo4.Text) > 175)
            {
                MessageBox.Show("Kut mora biti manji od 175°.");
            }
            else if (Convert.ToInt32(txtServo1.Text) < 5 || Convert.ToInt32(txtServo2.Text) < 5 || Convert.ToInt32(txtServo3.Text) < 5 || Convert.ToInt32(txtServo4.Text) < 5)
            {
                MessageBox.Show("Kut mora biti veći od 5°.");
            }
            else
            {
                try
                {
                    if (pozicija > 1 && pozicija <= Convert.ToInt32(txtBrojKoraka.Text))
                    {
                        brojNaredbe = brojNaredbe + 4;
                        naredba[brojNaredbe] = Convert.ToByte(txtServo1.Text);
                        textBox1.AppendText("Hvataljka: " +
                            "\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe] + "\n");
                        naredba[brojNaredbe + 1] = Convert.ToByte(txtServo2.Text);
                        textBox1.AppendText("Lakat: " +
                             "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe + 1] + "\n");
                        naredba[brojNaredbe + 2] = Convert.ToByte(txtServo3.Text);
                        textBox1.AppendText("Rame: " +
                             "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe + 2] + "\n");
                        naredba[brojNaredbe + 3] = Convert.ToByte(txtServo4.Text);
                        textBox1.AppendText("Baza: " +
                             "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe + 3] + "\n");
                        textBox1.AppendText("\nSpremljena pozicija " + pozicija + ". " + "\n");
                        pozicija++;
                        txtServo1.Clear();
                        txtServo2.Clear();
                        txtServo3.Clear();
                        txtServo4.Clear();
                        if (pozicija > Convert.ToInt32(txtBrojKoraka.Text))
                        {
                            btnSpremi.Enabled = false;
                            MessageBox.Show("Broj odabranih pozicija je postignut.");

                        }

                    }
                    else if (pozicija == 1)
                    {

                        brojNaredbe = 0;
                        naredba[brojNaredbe] = Convert.ToByte(txtServo1.Text);
                        textBox1.AppendText("Hvataljka: " +
                            "\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe] + "\n");
                        naredba[brojNaredbe + 1] = Convert.ToByte(txtServo2.Text);
                        textBox1.AppendText("Lakat: " +
                             "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe + 1] + "\n");
                        naredba[brojNaredbe + 2] = Convert.ToByte(txtServo3.Text);
                        textBox1.AppendText("Rame: " +
                             "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe + 2] + "\n");
                        naredba[brojNaredbe + 3] = Convert.ToByte(txtServo4.Text);
                        textBox1.AppendText("Baza: " +
                             "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[brojNaredbe + 3] + "\n");
                        textBox1.AppendText("\nSpremljena pozicija " + pozicija + ". " + "\n");
                        pozicija++;
                        txtServo1.Clear();
                        txtServo2.Clear();
                        txtServo3.Clear();
                        txtServo4.Clear();
                        if (pozicija > Convert.ToInt32(txtBrojKoraka.Text))
                        {
                            btnSpremi.Enabled = false;
                            MessageBox.Show("Broj odabranih pozicija je postignut.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Broj odabranih pozicija je postignut.");
                    }



                    /*

                        switch (pozicija)
                        {
                            case 1:
                                naredba[0] = Convert.ToByte(txtServo1.Text);
                                textBox1.AppendText("Hvataljka: " +
                                    "\tPozicija: " + pozicija + "\t\tKut: " + naredba[0] + "\n");
                                naredba[1] = Convert.ToByte(txtServo2.Text);
                                textBox1.AppendText("Lakat: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[1] + "\n");
                                naredba[2] = Convert.ToByte(txtServo3.Text);
                                textBox1.AppendText("Rame: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[2] + "\n");
                                naredba[3] = Convert.ToByte(txtServo4.Text);
                                textBox1.AppendText("Baza: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[3] + "\n");
                                textBox1.AppendText("Spremljena pozicija 1. " + "\n");

                                txtServo1.Clear();
                                txtServo2.Clear();
                                txtServo3.Clear();
                                txtServo4.Clear();
                                pozicija++;


                                break;

                            case 2:
                                naredba[4] = Convert.ToByte(txtServo1.Text);
                                textBox1.AppendText("Hvataljka: " +
                                    "\tPozicija: " + pozicija + "\t\tKut: " + naredba[4] + "\n");
                                naredba[5] = Convert.ToByte(txtServo2.Text);
                                textBox1.AppendText("Lakat: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[5] + "\n");
                                naredba[6] = Convert.ToByte(txtServo3.Text);
                                textBox1.AppendText("Rame: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[6] + "\n");
                                naredba[7] = Convert.ToByte(txtServo4.Text);
                                textBox1.AppendText("Baza: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[7] + "\n");
                                textBox1.AppendText("Spremljena pozicija 2. " + "\n");

                                txtServo1.Clear();
                                txtServo2.Clear();
                                txtServo3.Clear();
                                txtServo4.Clear();
                                pozicija++;


                                break;
                            case 3:
                                naredba[8] = Convert.ToByte(txtServo1.Text);
                                textBox1.AppendText("Hvataljka: " +
                                    "\tPozicija: " + pozicija + "\t\tKut: " + naredba[8] + "\n");
                                naredba[9] = Convert.ToByte(txtServo2.Text);
                                textBox1.AppendText("Lakat: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[9] + "\n");
                                naredba[10] = Convert.ToByte(txtServo3.Text);
                                textBox1.AppendText("Rame: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[10] + "\n");
                                naredba[11] = Convert.ToByte(txtServo4.Text);
                                textBox1.AppendText("Baza: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[11] + "\n");
                                textBox1.AppendText("Spremljena pozicija 3. " + "\n");

                                txtServo1.Clear();
                                txtServo2.Clear();
                                txtServo3.Clear();
                                txtServo4.Clear();
                                pozicija++;


                                break;

                            case 4:
                                naredba[12] = Convert.ToByte(txtServo1.Text);
                                textBox1.AppendText("Hvataljka: " +
                                    "\tPozicija: " + pozicija + "\t\tKut: " + naredba[12] + "\n");
                                naredba[13] = Convert.ToByte(txtServo2.Text);
                                textBox1.AppendText("Lakat: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[13] + "\n");
                                naredba[14] = Convert.ToByte(txtServo3.Text);
                                textBox1.AppendText("Rame: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[14] + "\n");
                                naredba[15] = Convert.ToByte(txtServo4.Text);
                                textBox1.AppendText("Baza: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[15] + "\n");
                                textBox1.AppendText("Spremljena pozicija 4. " + "\n");

                                txtServo1.Clear();
                                txtServo2.Clear();
                                txtServo3.Clear();
                                txtServo4.Clear();
                                pozicija++;


                                break;

                            case 5:
                                naredba[16] = Convert.ToByte(txtServo1.Text);
                                textBox1.AppendText("Hvataljka: " +
                                    "\tPozicija: " + pozicija + "\t\tKut: " + naredba[16] + "\n");
                                naredba[17] = Convert.ToByte(txtServo2.Text);
                                textBox1.AppendText("Lakat: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[17] + "\n");
                                naredba[18] = Convert.ToByte(txtServo3.Text);
                                textBox1.AppendText("Rame: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[18] + "\n");
                                naredba[19] = Convert.ToByte(txtServo4.Text);
                                textBox1.AppendText("Baza: " +
                                     "\t\tPozicija: " + pozicija + "\t\tKut: " + naredba[19] + "\n");
                                textBox1.AppendText("Spremljena pozicija 5. " + "\n");

                                txtServo1.Clear();
                                txtServo2.Clear();
                                txtServo3.Clear();
                                txtServo4.Clear();
                                pozicija++;
                                btnSpremi.Enabled = false;
                                btnSaveToTxt.Enabled = true;
                                break;
                        }
                        */

                }
                catch (Exception)
                {
                    MessageBox.Show("Neka greška");
                }
            }

        }

        public bool DetectArduino()
        {
            try
            {
                // "handshake" naredba
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                buffer[4] = Convert.ToByte(4);
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                currentPort.Open();
                currentPort.Write(buffer, 0, 11);
                Thread.Sleep(1000);
                int count = currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }

                currentPort.Close();
                if (returnMessage.Contains("Arduino je ovdje!"))
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nisam pronašao Arduino!");
                return false;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            int baud = Convert.ToInt16(cmbBaudRate.Text);
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, baud);
                    if (DetectArduino())
                    {
                        cmbPort.Text = port;
                        portFound = true;
                        MessageBox.Show("Arduino je spojen na " + port);
                        break;

                    }
                    else
                    {
                        portFound = false;
                        MessageBox.Show("Nisam pronašao Arduino!");

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                int polje = 0;
                int koraci = Convert.ToInt32(txtBrojKoraka.Text);

                for (int brojacKoraka = 1; brojacKoraka <= koraci + 1; brojacKoraka++)
                {
                    if (brojacKoraka == koraci + 1)
                    {
                        byte[] buffer = new byte[11];
                        buffer[0] = Convert.ToByte(16);
                        buffer[1] = Convert.ToByte(101);
                        buffer[2] = Convert.ToByte(0);
                        buffer[3] = Convert.ToByte(0);
                        buffer[4] = Convert.ToByte(0);
                        buffer[5] = Convert.ToByte(0);
                        buffer[6] = Convert.ToByte(0);
                        buffer[7] = Convert.ToByte(0);
                        buffer[8] = Convert.ToByte(0);
                        buffer[9] = Convert.ToByte(0);
                        buffer[10] = Convert.ToByte(4);

                        int intReturnASCII = 0;
                        char charReturnValue = (Char)intReturnASCII;

                        currentPort.Open();
                        currentPort.Write(buffer, 0, 11);
                        Thread.Sleep(1000);

                        try
                        {
                            string returnMessage = "";
                            while (!returnMessage.Contains("Gotov"))
                            {
                                int count = currentPort.BytesToRead;
                                while (count > 0)
                                {
                                    intReturnASCII = currentPort.ReadByte();
                                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                                    count--;
                                }
                            }
                            if (returnMessage.Contains("Gotov"))
                            {
                                //    MessageBox.Show("Primljeno! Pozicija: " + brojacKoraka + ". servo: " + servoSend + ".");
                                textBox1.AppendText("\nGotov!\n");
                                currentPort.Close();
                            }
                            else
                            {
                                textBox1.AppendText("Nešto ne valja! \n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nema komunikacije!");

                        }
                    }
                    else
                    {
                        byte[] buffer = new byte[11];
                        buffer[0] = Convert.ToByte(16);
                        buffer[1] = Convert.ToByte(121);
                        buffer[2] = Convert.ToByte(brojacKoraka);
                        buffer[3] = naredba[polje];
                        buffer[4] = Convert.ToByte(4);
                        buffer[5] = naredba[polje + 1];
                        buffer[6] = Convert.ToByte(4);
                        buffer[7] = naredba[polje + 2];
                        buffer[8] = Convert.ToByte(4);
                        buffer[9] = naredba[polje + 3];
                        buffer[10] = Convert.ToByte(4);

                        int intReturnASCII = 0;
                        char charReturnValue = (Char)intReturnASCII;

                        currentPort.Open();
                        currentPort.Write(buffer, 0, 11);
                        Thread.Sleep(1000);

                        try
                        {
                            string returnMessage = "";
                            while (!returnMessage.Contains("Pozicija"))
                            {
                                int count = currentPort.BytesToRead;
                                while (count > 0)
                                {
                                    intReturnASCII = currentPort.ReadByte();
                                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                                    count--;
                                }
                            }
                            if (returnMessage.Contains("Pozicija"))
                            {
                                //    MessageBox.Show("Primljeno! Pozicija: " + brojacKoraka + ". servo: " + servoSend + ".");
                                textBox1.AppendText("Primljeno! Pozicija: " + brojacKoraka + ". servo: " + ".\n");
                                currentPort.Close();
                            }
                            else
                            {
                                textBox1.AppendText("Nešto ne valja! \n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nema komunikacije!");

                        }

                        currentPort.Close();
                        polje = polje + 4;


                    }
                }
            }
            catch
            {
                MessageBox.Show("Slanje nije uspjelo.");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            /*
             * textBox1.Clear();
            
            for (int a = 0; a <= 10; a++)
            {
                naredba[a] = 0;
            }
            */
            FileStream fs = new FileStream("testIO.txt", FileMode.Open);
            int hexIn;
            int dec;


            for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
            {
                dec = Convert.ToInt16(hexIn);
                textBox1.AppendText(Convert.ToString(dec) + " - ");
            }

        }

        private void btnSaveToTxt_Click(object sender, EventArgs e)
        {
            if (File.Exists("testIO.txt"))
            {
                File.Delete("testIO.txt");
                File.WriteAllBytes("testIO.txt", naredba);
            }
            else
            {
                File.WriteAllBytes("testIO.txt", naredba);
            }


        }

        private void sakrij()

        {

            btnSpremi.Enabled = false;
            btnObrisi.Enabled = false;
            btnSaveToTxt.Enabled = false;
            btnPosaljiSve.Enabled = false;
            txtServo1.Enabled = false;
            txtServo2.Enabled = false;
            txtServo3.Enabled = false;
            txtServo4.Enabled = false;
        }
        private void prikazi()
        {
            btnSpremi.Enabled = true;
            btnObrisi.Enabled = true;
            btnSaveToTxt.Enabled = true;
            btnPosaljiSve.Enabled = true;
            txtServo1.Enabled = true;
            txtServo2.Enabled = true;
            txtServo3.Enabled = true;
            txtServo4.Enabled = true;
        }

        private void txtBrojKoraka_TextChanged(object sender, EventArgs e)
        {
            prikazi();
        }
    }
}


