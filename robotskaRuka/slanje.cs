using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotskaRuka
{
    public partial class slanje : Form
    {
        public slanje()
        {
            InitializeComponent();

        }

        byte[] popis = new byte[23];
        int pozicija = 1;
        SerialPort currentPort;
        bool portFound;

        int servoSend;
        int brojacKoraka;
        int popis_0 = 16;
        int popis_1 = 126;
        int popis_2 = 5;
        int popis_3 = 160;
        int popis_4 = 90;
        int popis_5 = 30;
        int popis_6 = 120;
        int popis_7 = 126;
        int popis_8 = 16;
        int popis_9 = 126;
        int popis_10 = 16;
        int popis_11 = 126;
        int popis_12 = 16;
        int popis_13 = 126;
        int popis_14 = 16;
        int popis_15 = 126;
        int popis_16 = 16;
        int popis_17 = 10;
        int popis_18 = 90;
        int popis_19 = 10;
        int popis_20 = 90;
        int popis_21 = 10;
        int popis_22 = 0;

        // spremanje kuteva
        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (pozicija)
                {
                    case 1:
                        popis_2 = Convert.ToByte(textBox2.Text);
                        textBox1.AppendText("Servo 1: " +
                            "\tPozicija: " + pozicija + "\tKut: " + popis_2 + "\n");
                        popis_7 = Convert.ToByte(textBox3.Text);
                        textBox1.AppendText("Servo 2: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_7 + "\n");
                        popis_12 = Convert.ToByte(textBox4.Text);
                        textBox1.AppendText("Servo 3: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_12 + "\n");
                        popis_17 = Convert.ToByte(textBox5.Text);
                        textBox1.AppendText("Servo 4: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_17 + "\n");
                        textBox1.AppendText("Spremljena pozicija 1. " + "\n");

                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        pozicija++;


                        break;

                    case 2:
                        popis_3 = Convert.ToByte(textBox2.Text);
                        textBox1.AppendText("Servo 1: " +
                            "\tPozicija: " + pozicija + "\tKut: " + popis_3 + "\n");
                        popis_8 = Convert.ToByte(textBox3.Text);
                        textBox1.AppendText("Servo 2: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_8 + "\n");
                        popis_13 = Convert.ToByte(textBox4.Text);
                        textBox1.AppendText("Servo 3: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_13 + "\n");
                        popis_18 = Convert.ToByte(textBox5.Text);
                        textBox1.AppendText("Servo 4: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_18 + "\n");
                        textBox1.AppendText("Spremljena pozicija 2. " + "\n");

                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        pozicija++;


                        break;
                    case 3:
                        popis_4 = Convert.ToByte(textBox2.Text);
                        textBox1.AppendText("Servo 1: " +
                            "\tPozicija: " + pozicija + "\tKut: " + popis_4 + "\n");
                        popis_9 = Convert.ToByte(textBox3.Text);
                        textBox1.AppendText("Servo 2: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_9 + "\n");
                        popis_14 = Convert.ToByte(textBox4.Text);
                        textBox1.AppendText("Servo 3: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_14 + "\n");
                        popis_19 = Convert.ToByte(textBox5.Text);
                        textBox1.AppendText("Servo 4: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_19 + "\n");
                        textBox1.AppendText("Spremljena pozicija 3. " + "\n");

                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        pozicija++;


                        break;

                    case 4:
                        popis_5 = Convert.ToByte(textBox2.Text);
                        textBox1.AppendText("Servo 1: " +
                            "\tPozicija: " + pozicija + "\tKut: " + popis_5 + "\n");
                        popis_10 = Convert.ToByte(textBox3.Text);
                        textBox1.AppendText("Servo 2: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_10 + "\n");
                        popis_15 = Convert.ToByte(textBox4.Text);
                        textBox1.AppendText("Servo 3: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_15 + "\n");
                        popis_20 = Convert.ToByte(textBox5.Text);
                        textBox1.AppendText("Servo 4: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_20 + "\n");
                        textBox1.AppendText("Spremljena pozicija 4. " + "\n");

                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        pozicija++;


                        break;

                    case 5:
                        popis_6 = Convert.ToByte(textBox2.Text);
                        textBox1.AppendText("Servo 1: " +
                            "\tPozicija: " + pozicija + "\tKut: " + popis_6 + "\n");
                        popis_11 = Convert.ToByte(textBox3.Text);
                        textBox1.AppendText("Servo 2: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_11 + "\n");
                        popis_16 = Convert.ToByte(textBox4.Text);
                        textBox1.AppendText("Servo 3: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_16 + "\n");
                        popis_21 = Convert.ToByte(textBox5.Text);
                        textBox1.AppendText("Servo 4: " +
                             "\tPozicija: " + pozicija + "\tKut: " + popis_21 + "\n");
                        textBox1.AppendText("Spremljena pozicija 5. " + "\n");

                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        button2.Enabled = false;
                        break;
                }

            }
            catch (Exception)
            { MessageBox.Show("Neka greška");
            }


        }

        public void button1_Click(object sender, EventArgs e)
        {
            pozicija = 1;
            button2.Enabled = true;
            textBox1.Clear();
            try
            {
                popis[0] = Convert.ToByte(16);
                popis[1] = Convert.ToByte(126);
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;

                currentPort.Open();
                currentPort.Write(popis, 0, 22);
                Thread.Sleep(1000);
                currentPort.Close();
              
            }
            catch {
                MessageBox.Show("Slanje nije uspjelo.");
            }
        }

  

        public bool DetectArduino()
        {
            try
            {
                // "handshake" naredba
                byte[] buffer = new byte[5];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                buffer[4] = Convert.ToByte(4);
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                currentPort.Open();
                currentPort.Write(buffer, 0, 5);
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
            int servoSend;
            int brojacKoraka;
            int pozicija;
           
            
            
            try
            {
                for (brojacKoraka = 1; brojacKoraka <= 5; brojacKoraka++)
                {
                    for (servoSend = 1; servoSend <= 4; servoSend++)
                    {
                        pozicija = brojacKoraka + 120;
                        byte[] buffer = new byte[5];
                        buffer[0] = Convert.ToByte(16);
                        buffer[1] = Convert.ToByte(pozicija);
                        buffer[2] = Convert.ToByte(servoSend);
                        if (servoSend == 1 && brojacKoraka == 1)
                        {
                            buffer[3] = Convert.ToByte(popis_2);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 2 && brojacKoraka == 1)
                        {
                            buffer[3] = Convert.ToByte(popis_7);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 3 && brojacKoraka == 1)
                        {
                            buffer[3] = Convert.ToByte(popis_12);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 4 && brojacKoraka == 1)
                        {
                            buffer[3] = Convert.ToByte(popis_17);
                            buffer[4] = Convert.ToByte(4);
                        }

                        else if (servoSend == 1 && brojacKoraka == 2)
                        {
                            buffer[3] = Convert.ToByte(popis_3);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 2 && brojacKoraka == 2)
                        {
                            buffer[3] = Convert.ToByte(popis_8);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 3 && brojacKoraka == 2)
                        {
                            buffer[3] = Convert.ToByte(popis_13);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 4 && brojacKoraka == 2)
                        {
                            buffer[3] = Convert.ToByte(popis_18);
                            buffer[4] = Convert.ToByte(4);
                        }

                        else if (servoSend == 1 && brojacKoraka == 3)
                        {
                            buffer[3] = Convert.ToByte(popis_4);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 2 && brojacKoraka == 3)
                        {
                            buffer[3] = Convert.ToByte(popis_9);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 3 && brojacKoraka == 3)
                        {
                            buffer[3] = Convert.ToByte(popis_14);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 4 && brojacKoraka == 3)
                        {
                            buffer[3] = Convert.ToByte(popis_19);
                            buffer[4] = Convert.ToByte(4);
                        }

                        else if (servoSend == 1 && brojacKoraka == 4)
                        {
                            buffer[3] = Convert.ToByte(popis_5);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 2 && brojacKoraka == 4)
                        {
                            buffer[3] = Convert.ToByte(popis_10);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 3 && brojacKoraka == 4)
                        {
                            buffer[3] = Convert.ToByte(popis_15);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 4 && brojacKoraka == 4)
                        {
                            buffer[3] = Convert.ToByte(popis_20);
                            buffer[4] = Convert.ToByte(4);
                        }

                        else if (servoSend == 1 && brojacKoraka == 5)
                        {
                            buffer[3] = Convert.ToByte(popis_6);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 2 && brojacKoraka == 5)
                        {
                            buffer[3] = Convert.ToByte(popis_11);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 3 && brojacKoraka == 5)
                        {
                            buffer[3] = Convert.ToByte(popis_16);
                            buffer[4] = Convert.ToByte(4);
                        }
                        else if (servoSend == 4 && brojacKoraka == 5)
                        {
                            buffer[3] = Convert.ToByte(popis_21);
                            buffer[4] = Convert.ToByte(4);
                        }

                        int intReturnASCII = 0;
                        char charReturnValue = (Char)intReturnASCII;

                        currentPort.Open();
                        currentPort.Write(buffer, 0, 5);
                        Thread.Sleep(1000);

                        try
                        {

                            int count = currentPort.BytesToRead;
                            string returnMessage = "";
                            while (count > 0)
                            {
                                intReturnASCII = currentPort.ReadByte();
                                returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                                count--;
                            }

                            
                            if (returnMessage.Contains("Primljeno!"))
                            {
                                //    MessageBox.Show("Primljeno! Pozicija: " + brojacKoraka + ". servo: " + servoSend + ".");
                                textBox1.AppendText("Primljeno! Pozicija: " + brojacKoraka + ". servo: " + servoSend + ".\n");
                            }
                            else
                            {

                                textBox1.AppendText("Pogreška slanja! Pozicija: " + brojacKoraka + ". servo: " + servoSend + ".\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nema povratne informacije!");
                            
                        }
                        currentPort.Close();


                    }
                }
            }
            catch
            {
                MessageBox.Show("Slanje nije uspjelo.");
            }
        }
        
        
    }
}

