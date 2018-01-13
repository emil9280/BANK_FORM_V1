using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;

namespace BANK_FORM_V1
{
    class MYSQL
    {
        private MySqlConnection conntection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public void Initiallize()
        {
            server = "localhost";
            database = "users";
            uid = "root";
            password = "3milHM9685";
            string connectionstring;
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            conntection = new MySqlConnection(connectionstring);
        }
        private bool open_connection()
        {
            try
            {
                conntection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        error_login error = new error_login();
                        error.Show();
                        break;
                    case 1045:
                        error_login error1 = new error_login();
                        error1.Show();
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conntection.Close();
                return true;
            }
            catch (MySqlException ex)
            {               
                Thread.Sleep(5000);
                return false;
            }
        }
        public List<string>[] SelectLogin()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.open_connection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conntection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["username"] + "");
                    list[1].Add(dataReader["password"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;
        }
    }
}
