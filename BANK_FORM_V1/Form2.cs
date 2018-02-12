using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_FORM_V1
{
    public partial class Form2 : Form
    {
        private int User_ID = 10;

        public Form2()
        {            
            InitializeComponent();
            MYSQL_balance mYSQL_Balance = new MYSQL_balance();
            List<string>[] list = mYSQL_Balance.Account_Checker();
            if (Account_Check)
            Pulled_data();
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

        private int[] Account_Check(List<string> user, string User_Input)
        {
            int returnvalue = 0;
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i] == User_Input)
                {
                    
                }
            }
        }

    }
}