﻿using System;
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

        }


        int pozicija = 1;
        SerialPort currentPort;
        bool portFound;

        byte[] naredba = new byte[20];


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

                            break;
                    }

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
                for (int brojacKoraka = 1; brojacKoraka <= 5; brojacKoraka++)
                {
                    
                    byte[] buffer = new byte[11];
                    buffer[0] = Convert.ToByte(16);
                    buffer[1] = Convert.ToByte(121);
                    buffer[2] = Convert.ToByte(brojacKoraka);
                    buffer[3] = naredba[polje];
                    buffer[4] = Convert.ToByte(4);
                    buffer[5] = naredba[polje+1];
                    buffer[6] = Convert.ToByte(4);
                    buffer[7] = naredba[polje+2];
                    buffer[8] = Convert.ToByte(4);
                    buffer[9] = naredba[polje+3];
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
                        }
                        else
                        {
                            textBox1.AppendText("Nešto ne valja! \n");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nema povratne informacije!");

                    }
                    currentPort.Close();
                    polje = polje + 4;


                }
            }
            catch
            {
                MessageBox.Show("Slanje nije uspjelo.");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int a = 0; a <= 10; a++)
            {
                naredba[a] = 0;
            }
            
        }
    }
}
