using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace BANK_FORM_V1
{
    class Pull_Balance
    {
        private int accounts; 
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public double Balance_1;
        public double Balance_2;
        public double Balance_3;
        public double Balance_4;
        public double Balance_5;
        public double Balance_6;
        public double Balance_7;
        public double Balance_8;
        public double Balance_9;
        public double Balance_10;

        public Pull_Balance()
        {
            Initiallize();
        }

        public List<string> account_ID()
        {
            SingleTon.GetID();
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

        private void account()
        {
            Form2 form = new Form2();
            accounts = form.Getaccount();
        }

        public List<string> account_0()
        {            
                string query = "SELECT balance FROM bankusers";
                List<string> list = new List<string>();
                list = new List<string>();

                if (this.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader DataReader = cmd.ExecuteReader();
                    while (DataReader.Read())
                    {
                        list.Add(DataReader["balance"] + "");
                    }

                    DataReader.Close();
                    this.CloseConnection();
                    return list;
                }
                else return list;            

        }

        public List<string>[] account_1()
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
                    list[0].Add(dataReader["balance2"] + "");
                    list[1].Add(dataReader["balance3"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_2()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_3()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_4()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                    list[4].Add(dataReader["balance5"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_5()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();


            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                    list[4].Add(dataReader["balance5"] + "");
                    list[5].Add(dataReader["balance6"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_6()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                    list[4].Add(dataReader["balance5"] + "");
                    list[5].Add(dataReader["balance6"] + "");
                    list[6].Add(dataReader["balance7"] + "");                    
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_7()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                    list[4].Add(dataReader["balance5"] + "");
                    list[5].Add(dataReader["balance6"] + "");
                    list[6].Add(dataReader["balance7"] + "");
                    list[7].Add(dataReader["balance8"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_8()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                    list[4].Add(dataReader["balance5"] + "");
                    list[5].Add(dataReader["balance6"] + "");
                    list[6].Add(dataReader["balance7"] + "");
                    list[7].Add(dataReader["balance8"] + "");
                    list[8].Add(dataReader["balance9"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }

        public List<string>[] account_9()
        {
            string query = "SELECT * FROM bankusers";

            List<string>[] list = new List<string>[10];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["balance"] + "");
                    list[1].Add(dataReader["balance2"] + "");
                    list[2].Add(dataReader["balance3"] + "");
                    list[3].Add(dataReader["balance4"] + "");
                    list[4].Add(dataReader["balance5"] + "");
                    list[5].Add(dataReader["balance6"] + "");
                    list[6].Add(dataReader["balance7"] + "");
                    list[7].Add(dataReader["balance8"] + "");
                    list[8].Add(dataReader["balance9"] + "");
                    list[9].Add(dataReader["balance10"] + "");                    
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else return list;

        }


    }
}
