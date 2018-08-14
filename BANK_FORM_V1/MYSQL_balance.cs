using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace BANK_FORM_V1
{
    class MYSQL_balance
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MYSQL_balance()
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
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Sslmode = none ;";
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
        public void User(string user)
        {
            string User = SingleTon.GetUser();
        }

        public List<string>[] Account_Checker()
        {
            string query = "SELECT accounts FROM bankusers";
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    list[0].Add(DataReader["accounts"] + "");
                }

                DataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;
        }

    }
}