using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace BANK_FORM_V1
{
    public partial class Form1 : Form
    {
        MYSQL mysql = new MYSQL();
        public int ID_;
        public Form1()
        {
            
            RFID rFID = new RFID();
            rFID.MyPort();
            InitializeComponent();
        }


        private void login_button_Click(object sender, EventArgs e)
        {
            SingleTon.SetUser(Username_TB.Text);

            List<string>[] list = mysql.SelectLogin();
            if (UserCheck(list[0], list[1], Username_TB.Text, Password_TB.Text))
            {
                
                SingleTon.SetID(ID_);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                Form error = new error_login();
                error.Show();
                Username_TB.Text = "";
                Password_TB.Text = "";

            }

        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            Form sign = new Signup();
            sign.Show();
            this.Hide();
        }

        private bool UserCheck(List<string> user, List<string> password, string userInput, string passInput)
        {
            bool returnvalue = false;
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i] == userInput)
                {
                    ID_ = i;
                    if (password[i] == passInput)
                    {
                        returnvalue = true;
                    }
                }
            }

            return returnvalue;
        }

        private void Password_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RFID_Click(object sender, EventArgs e)
        {
            RFID RFid = new RFID();
            string ID = RFid.main();
            string PIN = RFid.RFID_PIN();
            ID = ID.Remove(0, 1);
            PIN = PIN.Remove(0, 1);
            List<string>[] RFIDd = mysql.RFID();
            if (RFID_check(RFIDd[0], RFIDd[1], ID.Remove(12, 1), PIN.Remove(PIN.Length - 1, 1)))
            {
                SingleTon.SetID(ID_);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                Form error = new error_login();
                error.Show();
                Username_TB.Text = "";
                Password_TB.Text = "";

            }

        }
        private bool RFID_check(List<string> tag, List<string> PIN,  string ID, string Pin)
        {
            bool returnvalue = false;
            for (int i = 0; i < tag.Count; i++)
            {
                if (tag[i] == ID)
                {
                    ID_ = i;                    
                    if (PIN[i] == Pin)
                    {
                        returnvalue = true;
                    }
                }
            }

            return returnvalue;
        }
    }
}