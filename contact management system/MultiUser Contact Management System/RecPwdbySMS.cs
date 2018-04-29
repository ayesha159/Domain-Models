using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;


namespace MultiUser_Contact_Management_System
{
    class RecPwdbySMS
    
        
    {
        public RecPwdbySMS() { }
        SerialPort MyserialPort;
        public void SetComPort(string PCcomPort)
        {
            this.MyserialPort = new SerialPort();
            this.MyserialPort.PortName = PCcomPort;
            this.MyserialPort.BaudRate = 9600;
            this.MyserialPort.Parity = Parity.None;
            this.MyserialPort.DataBits = 8;
            this.MyserialPort.StopBits = StopBits.One;
            //this.MyserialPort.Handshake = Handshake.RequestToSend;
            //this.MyserialPort.DtrEnable = true;
            //this.MyserialPort.RtsEnable = true;
            this.MyserialPort.NewLine = System.Environment.NewLine;
        }
        public bool RecoverPwdbySMS(string cellNo, string sms)
        {
            string messages = null;
            messages = sms;
            if (this.MyserialPort.IsOpen == true)
            {
                try
                {
                    this.MyserialPort.WriteLine("AT" + (char)(13));
                    Thread.Sleep(2000);
                    this.MyserialPort.WriteLine("AT+CMGF=1" + (char)(13));
                    Thread.Sleep(3000);
                    this.MyserialPort.WriteLine("AT+CMGS=\"" + cellNo + "\"");
                    Thread.Sleep(5000);
                    this.MyserialPort.WriteLine("" + messages + (char)(26));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source);
                }
                return true;
            }
            else
                return false;
        }

        public void Opens()
        {
            if (this.MyserialPort.IsOpen == false)
            {
                this.MyserialPort.Open();
            }
        }

        public void Closes()
        {
            if (this.MyserialPort.IsOpen == true)
            {
                this.MyserialPort.Close();
            }
        }
    }
}
