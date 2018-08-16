using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;

namespace BANK_FORM_V1
{
    public partial class Form2 : Form
    {
        private int User_ID;
        private int account;
        public int ID = SingleTon.GetID();
        public List<string> Balance_List;

        public Form2()
        {
            InitializeComponent();
            Pull_Balance balance = new Pull_Balance();
            MYSQL_balance mYSQL_Balance = new MYSQL_balance();
            List<string> list = mYSQL_Balance.Account_Checker();
            account = Convert.ToInt16(list[ID]);
            Account_Check();
            Pulled_data();
            Account_CB.DataSource = balance.account();
            if (User_ID == -1)
            {
                general_error general_Error = new general_error();
                general_Error.Show();
            }
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            Form Help = new help();
            Help.Show();
        }

        private void Transfere_button_Click(object sender, EventArgs e)
        {
            Form trans = new Transfere();
            trans.Show();
        }

        private void Pulled_data()
        {
            User_ID_number_label.Text = "User ID:" + User_ID;
        }
        private void Account_Check()
        {
            User_ID = SingleTon.GetID();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int Getaccount()
        {
            return account;
        }

       
    }
}