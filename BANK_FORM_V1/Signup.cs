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

namespace BANK_FORM_V1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form can_1 = new Form1();
            can_1.Show();
        }

        #region add_user
        private void add_user_Click(object sender, EventArgs e)
        {
            if (new_password_tb.Text == repass_tb.Text && new_username_tb.Text != "" && new_email_tb.Text != "" && new_password_tb.Text != "" && full_name_tb.Text != "")
            {
                string server = "localhost";
                string database = "users";
                string uid = "root";
                string password = "3milHM9685";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                MySqlConnection connection = new MySqlConnection(connectionString);

                string Query = "insert into users.bankusers(username,password,full_name,email) values('" + new_username_tb.Text + "','"+new_password_tb.Text+"','"+full_name_tb.Text+"','"+new_email_tb.Text+"');";

                MySqlCommand Mycom = new MySqlCommand(Query, connection);
                MySqlDataReader myreader;
                connection.Open();
                myreader = Mycom.ExecuteReader();
                while(myreader.Read())
                {

                }
                connection.Close();
                this.Close();
                Form log = new Form1();
                log.Show();
            }
            else
            {
                new_username_tb.Text = "";
                new_password_tb.Text = "";
                repass_tb.Text = "";
                new_email_tb.Text = "";
                Form err_sign = new error_signup();
                err_sign.Show();
            }
        }
        #endregion
    }
}
