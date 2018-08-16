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
        public string RFid;
        public void main()
        {
            bool connection = true;
            var myPort = new SerialPort("COM3", 9600);
            myPort.DtrEnable = true;
            myPort.Open();
            while (connection == true)
            {
                var s = myPort.ReadLine();
                RFid = s;
                connection = false;
            }
            myPort.Close();
        }
        public string RFID_ID()
        {
            main();
            return RFid;
        }
    }
}
