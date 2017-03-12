using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace robotskaRuka
{


    public partial class Form1 : Form
    {
        // postavljanje varijabli
        int servoPos1 = 80;
        int servoPos2 = 160;
        int servoPos3 = 70;
        int servoPos4 = 95;

        SerialPort currentPort;
        bool portFound;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showServoPos();
        }

        // osiguravanje zatvaranja porta kada se zatvori aplikacija
        private void Form1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            
            if (currentPort != null)
            {
                currentPort.Close();
                }
        }

        // ispis odabranih kuteva
        public void showServoPos()
        {
            txtServoPos1.Text = Convert.ToString(servoPos1);
            txtServoPos2.Text = Convert.ToString(servoPos2);
            txtServoPos3.Text = Convert.ToString(servoPos3);
            txtServoPos4.Text = Convert.ToString(servoPos4);
        }

        // smanjivanje kuta za 1° - Servo 1
        private void servo1Manje_Click(object sender, EventArgs e)
        {
            if (servoPos1 < 16)
            {
                servoPos1 = 15;
                scrollServo1.Value = servoPos1;
            }
            else
            {
                servoPos1 = servoPos1 - 1;
                scrollServo1.Value = servoPos1;
            }
            showServoPos();
        }

        // smanjivanje kuta za 1° - Servo 2
        private void servo2Manje_Click(object sender, EventArgs e)
        {
            if (servoPos2 < 6)
            {
                servoPos2 = 5;
            }
            else
            {
                servoPos2 = servoPos2 - 1;
            }
            showServoPos();
        }

        // smanjivanje kuta za 1° - Servo 3
        private void servo3Manje_Click(object sender, EventArgs e)
        {
            if (servoPos3 < 6)
            {
                servoPos3 = 5;
                scrollServo3.Value = servoPos3;
            }
            else
            {
                servoPos3 = servoPos3 - 1;
                scrollServo3.Value = servoPos3;
            }
            showServoPos();
        }

        // smanjivanje kuta za 1° - Servo 4
        private void servo4Manje_Click(object sender, EventArgs e)
        {
            if (servoPos4 < 6)
            {
                servoPos4 = 5;
                scrollServo3.Value = servoPos4;
            }
            else
            {
                servoPos4 = servoPos4 - 1;
                scrollServo3.Value = servoPos4;
            }
            showServoPos();
        }

        // povećavanje kuta za 1° - Servo 1
        private void servo1Vise_Click(object sender, EventArgs e)
        {
            if (servoPos1 > 79)
            {
                servoPos1 = 80;
                scrollServo1.Value = servoPos1;
                
            }
            else
            {
                servoPos1 = servoPos1 + 1;
                scrollServo1.Value = servoPos1;
            }
            showServoPos();            
        }

        // povećavanje kuta za 1° - Servo 2 
        private void servo2Vise_Click(object sender, EventArgs e)
        {
            if (servoPos2 > 174)
            {
                servoPos2 = 175;
            }
            else
            {
                servoPos2 = servoPos2 + 1;
            }
            showServoPos();
        }

        // povećavanje kuta za 1° - Servo 3
        private void servo3Vise_Click(object sender, EventArgs e)
        {
            if (servoPos3 > 174)
            {
                servoPos3 = 175;
                scrollServo3.Value = servoPos3;
            }
            else
            {
                servoPos3 = servoPos3 + 1;
                scrollServo3.Value = servoPos3;
            }
            showServoPos();
        }

        // povećavanje kuta za 1° - Servo 4
        private void servo4Vise_Click(object sender, EventArgs e)
        {
            if (servoPos4 > 174)
            {
                servoPos4 = 175;
                scrollServo4.Value = servoPos4;

            }
            else
            {
                servoPos4 = servoPos4 + 1;
                scrollServo4.Value = servoPos4;
            }
            showServoPos();
        }

        // kontrola kuta pomoću scrollBar-a - Servo 1
        private void scrollServo1_Scroll(object sender, ScrollEventArgs e)
        {
            servoPos1 = scrollServo1.Value;
            showServoPos();
            
        }

        // kontrola kuta pomoću scrollBar-a - Servo 2
        private void scrollServo2_Scroll(object sender, ScrollEventArgs e)
        {
            servoPos2 = scrollServo2.Value;
            showServoPos();
        }

        // kontrola kuta pomoću scrollBar-a  - Servo 3
        private void scrollServo3_Scroll(object sender, ScrollEventArgs e)
        {
            servoPos3 = scrollServo3.Value;
            showServoPos();
        }

        // kontrola kuta pomoću scrollBar-a  - Servo 4
        private void scrollServo4_Scroll(object sender, ScrollEventArgs e)
        {
            servoPos4 = scrollServo4.Value;
            showServoPos();
        }
        
        // pali LED
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                paliLed();
            }
            catch (Exception ex)
            { MessageBox.Show("Nisam spojen!"); }
        }

        // gasi LED
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                gasiLed();
            }
            catch (Exception ex)
            { MessageBox.Show("Nisam spojen!"); }
        }
        
        // pronalaženje COM porta na kojem je spojen Arduino
        public void button7_Click(object sender, EventArgs e)
        {
            SetComPort();
        }

        // metoda za pronalaženje COM porta na kojem je spojen Arduino
        public void SetComPort()
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
            catch (Exception e)
            {
                
            }
        }

        // metoda za pronalaženje Arduina
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
                int count = currentPort.BytesToRead;
                txtTestBytes.Text = Convert.ToString(count);
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }

                txtStatus.Text = "Spreman!";
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
            catch (Exception ex)
            {
                MessageBox.Show("Nisam pronašao Arduino!");
                return false;
            }
        }


        // slanje naredbe za uključivanje LED-a
        private void paliLed()
        {
            try
            {
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(127);
                buffer[2] = Convert.ToByte(6);
                buffer[3] = Convert.ToByte(255);
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

                txtStatus.Text = "Pali LED";
                currentPort.Close();
                picLedOff.Visible = false;
                picLedOn.Visible = true;
            }
            catch { }
            }


        // slanje naredbe za isključivanje LED-a
        private void gasiLed()
        {
            try
            {
                //The below setting are for the Hello handshake
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(127);
                buffer[2] = Convert.ToByte(6);
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

                txtStatus.Text = "Gasi LED";
                currentPort.Close();
                picLedOff.Visible = true;
                picLedOn.Visible = false;
            }
            catch { }
        }

        //slanje naredbe za pozicioniranje Servo 1
        private void sendServo1()
        {
            int servoPos = Convert.ToInt16(txtServoPos1.Text);
            try
            {
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(127);
                buffer[2] = Convert.ToByte(1);
                buffer[3] = Convert.ToByte(servoPos1);
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

                txtStatus.Text = returnMessage;
                currentPort.Close();
            }
            catch { }
        }

        //slanje naredbe za pozicioniranje Servo 2
        private void sendServo2()
        {
            int servoPos = Convert.ToInt16(txtServoPos2.Text);
            try
            {
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(127);
                buffer[2] = Convert.ToByte(2);
                buffer[3] = Convert.ToByte(servoPos2);
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

                txtStatus.Text = returnMessage;
                currentPort.Close();
            }
            catch { }
        }

        //slanje naredbe za pozicioniranje Servo 3
        private void sendServo3()
        {
            int servoPos = Convert.ToInt16(txtServoPos3.Text);
            try
            {
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(127);
                buffer[2] = Convert.ToByte(3);
                buffer[3] = Convert.ToByte(servoPos3);
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

                txtStatus.Text = returnMessage;
                currentPort.Close();
            }
            catch { }
        }

        //slanje naredbe za pozicioniranje Servo 4
        private void sendServo4()
        {
            int servoPos = Convert.ToInt16(txtServoPos4.Text);
            try
            {
                byte[] buffer = new byte[11];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(127);
                buffer[2] = Convert.ToByte(4);
                buffer[3] = Convert.ToByte(servoPos4);
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

                txtStatus.Text = returnMessage;
                currentPort.Close();
            }
            catch { }
        }
        
        
        // otvaranje CopyRight forme
        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyRight frmCopyRight = new copyRight();
            frmCopyRight.Show();
        }
        
        // slanje pozicije za Servo 1
        private void btnServo1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos1.Text) < 15)
            {
                MessageBox.Show("Kut hvataljke ne smije biti manji od 15°.");
                txtServoPos1.Text = "15";
            }
            else
            {
                sendServo1();
            }
            
        }
        
        // slanje pozicije za Servo 2
        private void btnServo2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos2.Text) < 5)
            {
                MessageBox.Show("Kut ne smije biti manji od 5°.");
                txtServoPos2.Text = "5";
            }
            else
            {
                sendServo2();
            }
        }

        // slanje pozicije za Servo 3
        private void btnServo3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos3.Text) < 5)
            {
                MessageBox.Show("Kut ne smije biti manji od 5°.");
                txtServoPos3.Text = "5";
            }
            else
            {
                sendServo3();
            }
        }

        // slanje pozicije za Servo 4
        private void brnServo4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos4.Text) < 5)
            {
                MessageBox.Show("Kut ne smije biti manji od 5°.");
                txtServoPos4.Text = "5";
            }
            else
            {
                sendServo4();
            }
        }
        
        // slanje svih pozicija odjednom
        private void btnPosaljiSve_Click(object sender, EventArgs e)
        {
            sendServo1();
            sendServo2();
            sendServo3();
            sendServo4();
        }
        
        // otvaranje forme za unos 5 pozicija
        private void button2_Click(object sender, EventArgs e)
        {
            slanje frmSlanje2 = new slanje();
            frmSlanje2.Show();
        }

        private void txtServoPos1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos1.Text) < 5)
            {
            }
            else if (Convert.ToInt16(txtServoPos1.Text) > 80)
            {
                MessageBox.Show("Kut hvataljke ne smije biti veći od 80°.");
                txtServoPos1.Text = "80";
            }
            else
            {
                scrollServo1.Value = Convert.ToInt16(txtServoPos1.Text);
            }
        }

        private void txtServoPos2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos2.Text) < 5)
            {
            }
            else if (Convert.ToInt16(txtServoPos2.Text) > 175)
            {
                MessageBox.Show("Kut ne smije biti veći od 175°.");
                txtServoPos2.Text = "175";
            }
            else
            {
                scrollServo2.Value = Convert.ToInt16(txtServoPos2.Text);
            }
        }

        private void txtServoPos3_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos3.Text) < 5)
            {
            }
            else if (Convert.ToInt16(txtServoPos3.Text) > 175)
            {
                MessageBox.Show("Kut ne smije biti veći od 175°.");
                txtServoPos3.Text = "175";
            }
            else
            {
                scrollServo3.Value = Convert.ToInt16(txtServoPos3.Text);
            }
        }

        private void txtServoPos4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtServoPos4.Text) < 5)
            {
            }
            else if (Convert.ToInt16(txtServoPos4.Text) > 175)
            {
                MessageBox.Show("Kut ne smije biti veći od 175°.");
                txtServoPos4.Text = "175";
            }
            else
            {
                scrollServo4.Value = Convert.ToInt16(txtServoPos4.Text);
            }
        }
    }
}
