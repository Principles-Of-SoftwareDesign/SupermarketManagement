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
        public IEnumerable<CashierModel> GetAllCashiers()
        {
            var cashiers = new List<CashierModel>();
            //connection.Open();
            OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM `users` WHERE role=0", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var cashierModel = new CashierModel();
                //cashierModel.Id = (int)reader["id"];
                cashierModel.Name = reader["name"].ToString();
                cashierModel.Email = reader["email"].ToString();
                cashierModel.PhoneNumber = reader["phone_number"].ToString();
                cashierModel.Password = reader["password"].ToString();
                cashiers.Add(cashierModel);
            }
            reader.Close();
            CloseConnection();
            //connection.Close();
            return cashiers;
        }

        public bool addCashier(CashierModel cashier)
        {
            OpenConnection();
            var cmd = new MySqlCommand("INSERT INTO `users` (`name`, `email`, `phone_number`, `password`, `role`) VALUES (@Name, @Email, @PhoneNumber, @Password, @Role)", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", cashier.Name);
            cmd.Parameters.AddWithValue("@Email", cashier.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", cashier.PhoneNumber);
            cmd.Parameters.AddWithValue("@Password", cashier.Password);
            cmd.Parameters.AddWithValue("@Role", cashier.Role);

            int rowsAffected = cmd.ExecuteNonQuery();
           CloseConnection();

            return rowsAffected > 0;
        }
        

        public bool UpdateCashier(CashierModel cashier)
        {
            connection.Open();
            var cmd = new MySqlCommand("UPDATE `users` SET `name`=@name,`email`=@email,`phone_number`=@phone_number, `password`=@password WHERE `name`=@name", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", cashier.Name);
            cmd.Parameters.AddWithValue("@email", cashier.Email);
            cmd.Parameters.AddWithValue("@phone_number", cashier.PhoneNumber);
            cmd.Parameters.AddWithValue("@password", cashier.Password);
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected > 0;
        }
        public bool DeleteCashier(String cashierName)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE `name`=@name", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", cashierName);
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected > 0;
        }

        /*public IEnumerable<CashierModel> GetAllCashiers()
        {
            throw new NotImplementedException();
        }*/
    }
}


