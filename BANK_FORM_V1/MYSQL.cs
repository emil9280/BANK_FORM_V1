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
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MYSQL()
        {
            Initiallize();
        }

        private void Initiallize()
        {
            server = "localhost";
            database = "users";
            uid = "root";
            password = "3milHM9685";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Sslmode = none;";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        
                        Thread.Sleep(5000);
                        break;

                    case 1045:
                        
                        Thread.Sleep(5000);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                
                Thread.Sleep(5000);
                return false;
            }
        }

        public string SelectLogin()
        {
            string username = SingleTon.GetUser();
            //string query = "SELECT * FROM bankusers";
            string query = "SELECT username, password FROM bankusers WHERE bankusers.username = '" + username + "'";

            //List<string>[] list = new List<string>[2];
            //list[0] = new List<string>();
            //list[1] = new List<string>();
            string username1;
            string password;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    username1 = Convert.ToString(dataReader["username"] + "");
                    
                    password = Convert.ToString(dataReader["password"] + "");
                    //list[0].Add(dataReader["username"] + "");
                    //list[1].Add(dataReader["password"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return username1, password;
            }
            else return username1, password;
        }

        public List<string>[] RFID()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["RFID"] + "");
                    list[1].Add(dataReader["RFID_PIN"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;
        }
    }
}