using MySql.Data.MySqlClient;
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

        public bool AddCashier(CashierModel cashierModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashierModel> GetAllCashiers()
        {
            throw new NotImplementedException();
        }
    }
}
