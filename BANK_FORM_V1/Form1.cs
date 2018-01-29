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

namespace BANK_FORM_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            MYSQL mysql = new MYSQL();
            List<string>[] list = mysql.SelectLogin();
            if (UserCheck(list[0], list[1], Username_TB.Text, Password_TB.Text))
            {
                SingleTon.SetUser(Username_TB.Text);
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
    }
}