using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace BANK_FORM_V1
{
    class RFID
    {
        //public SerialPort myPort = new SerialPort("COM3", 9600);
        bool connection = true;
        public void MyPort()
        {
            //myPort.DtrEnable = true;
            //myPort.Open();            
        }
        public string RFid;
        public string PIN;
        public string main()
        {
            var myPort = new SerialPort("COM3", 9600);
            myPort.DtrEnable = true;
            myPort.Open();
            System.Threading.Thread.Sleep(5000);
            while (connection == true)
            {
                myPort.WriteLine("CARD");
                System.Threading.Thread.Sleep(1000);
                var s = myPort.ReadLine();
                connection = false;
                return s;
            }
            return RFid;
        }
        public string PIN_()
        {
            bool connection = true;
            var myPort = new SerialPort("COM3", 9600);
            myPort.DtrEnable = true;
            myPort.Open();
            while (connection == true)
            {
                myPort.WriteLine("PIN");
                var d = myPort.ReadLine();
                connection = false;
                return d;
            }
            myPort.Close();
            return PIN;
        }
        public string RFID_ID()
        {
            main();
            return RFid;
        }
        public string RFID_PIN()
        {
            PIN_();
            return PIN;
        }
    }
}
