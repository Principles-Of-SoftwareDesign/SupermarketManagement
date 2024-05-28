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
        public void EditCashier(CashierModel cashierModel)
        {
            throw new NotImplementedException();
        }

       

        public bool addCashier(CashierModel cashier)
        {
            //OpenConnection();
            var cmd = new MySqlCommand("INSERT INTO users (name, email, phone_number, password, role) VALUES (@Name, @Email, @PhoneNumber, @Password, @Role)", connection);
            cmd.Parameters.AddWithValue("@Name", cashier.Name);
            cmd.Parameters.AddWithValue("@Email", cashier.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", cashier.PhoneNumber);
            cmd.Parameters.AddWithValue("@Password", cashier.Password);
            cmd.Parameters.AddWithValue("@Role", cashier.Role);

            int rowsAffected = cmd.ExecuteNonQuery();
           // CloseConnection();

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

        public IEnumerable<CashierModel> GetAllCashiers()
        {
            throw new NotImplementedException();
        }
    }
}


