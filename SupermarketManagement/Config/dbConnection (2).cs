using MySql.Data.MySqlClient;

namespace SupermarketManagement
{
    internal class dbConnection
    {
        public dbConnection()
        {
        }

        public string connect()
        {
            string conn = "Datasource=localhost; username=root; database=supermarket; password=";
            return conn;
        }
    }
}
