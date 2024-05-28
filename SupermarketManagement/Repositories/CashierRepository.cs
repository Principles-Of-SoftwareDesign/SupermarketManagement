using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using SupermarketManagement.Config;
using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Repositories
{
    public class CashierRepository : Repository, ICashierRepository
    {
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private dbConnection dbconnection = new dbConnection();
        public CashierRepository()
        {
            this.connection = new MySqlConnection(dbconnection.connect());
        }
        public void EditCashier(CashierModel cashierModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashierModel> GetAllCashiers()
        {
            var cashiers = new List<CashierModel>();
            connection.Open();
            cmd = new MySqlCommand("SELECT * FROM `users` WHERE role=0", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var cashierModel = new CashierModel();
                cashierModel.Id = (int)reader["id"];
                cashierModel.Name = reader["name"].ToString();
                cashierModel.Email = reader["email"].ToString();
                cashierModel.PhoneNumber = reader["phone_number"].ToString();
                cashiers.Add(cashierModel);
            }
            reader.Close();
            connection.Close();

            return cashiers;
        }

        public bool addCashier(CashierModel cashier)
        {
            connection.Open();
            var cmd = new MySqlCommand("INSERT INTO users (name, email, phone_number, password, role) VALUES (@Name, @Email, @PhoneNumber, @Password, @Role)", connection);
            cmd.Parameters.AddWithValue("@Name", cashier.Name);
            cmd.Parameters.AddWithValue("@Email", cashier.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", cashier.PhoneNumber);
            cmd.Parameters.AddWithValue("@Password", cashier.Password);
            cmd.Parameters.AddWithValue("@Role", cashier.Role);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }


        public bool UpdateCashier(CashierModel cashier)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `name`=@name,`email`=@email,`password`=@password,`phone_number`=@phone_number WHERE `name`=@name", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", cashier.Name);
            cmd.Parameters.AddWithValue("@email", cashier.Email);
            cmd.Parameters.AddWithValue("@password", cashier.Password);
            cmd.Parameters.AddWithValue("@phone_number", cashier.PhoneNumber);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            return i > 0;
        }
        public bool DeleteCashier(String cashierName)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE `name`=@name", connection);
            cmd.Parameters.Clear();
           cmd.Parameters.AddWithValue("@name", cashierName);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

    }
}


