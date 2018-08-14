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
        private int accounts_data;
        private int account;
        public int ID = SingleTon.GetID();

        public Form2()
        {
            InitializeComponent();
            MYSQL_balance mYSQL_Balance = new MYSQL_balance();
            List<string>[] list = mYSQL_Balance.Account_Checker();
            account = list[ID].
            Account_Check();
            Pulled_data();
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
            accounts_data = SingleTon.GetID();
        }

        /*private int Account_Check(List<string> user, List<string> accounts, List<string> ID, string User_Input)
        {            
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i] == User_Input)
                {
                    accounts_data = Convert.ToInt16(accounts);
                    User_ID = Convert.ToInt16(ID);
                }
                else
                {
                    return User_ID = -1;
                }
            }
            return -1;
        }*/

    }
}