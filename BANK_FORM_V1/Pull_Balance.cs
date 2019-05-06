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

        public Pull_Balance()
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
        public  List<string>[] account()
        {
            accounts = SingleTon.GetID();

            List<string>[] list = new List<string>[10];
            for(int i = 0; i <= accounts+1; i++)
            {
                list[i] = new List<string>();
            }

            string username = SingleTon.GetUser();

            string query = "SELECT username, password FROM bankusers WHERE bankusers.username = '"+username+"'" ;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                /*for (int i = 0; i <= accounts + 1; i++)
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        list[i].Add(dataReader["balance" + i] + "");//rediger for at få det rigtige beløb ud når vi trækker balance for lige nu tager den det nummer på rækken og sender ud istedetfor det tal der står på den plads
                    }
                    dataReader.Close();
                }*/

                this.CloseConnection();
                return list;
            }
            else return list;

        }        

    }
}