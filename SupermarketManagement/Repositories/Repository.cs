using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using SupermarketManagement.Config;

namespace SupermarketManagement.Repositories
{
    public abstract class Repository
    {
        protected MySqlConnection connection;
        protected MySqlCommand cmd;
        protected MySqlDataReader reader;
        private dbConnection dbconnection = new dbConnection();


        // Common database connection setup
        public Repository()
        {
            connection = new MySqlConnection(dbconnection.connect());
        }

        // Common method to open connection
        protected void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Common method to close connection
        protected void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}



