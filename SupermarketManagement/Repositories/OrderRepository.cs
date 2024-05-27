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
    public class OrderRepository : Repository, IOrderRepository
    {


        public bool addOrder(addOrderModel order)
        {
            connection.Open();
            var cmd = new MySqlCommand("INSERT INTO users (name, email, phone_number, password, role) VALUES (@Name, @Email, @PhoneNumber, @Password, @Role)", connection);
            cmd.Parameters.AddWithValue("@Name", order.Name);
            cmd.Parameters.AddWithValue("@Email", order.Price);
            cmd.Parameters.AddWithValue("@Role", order.Amount);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

        public bool AddCashier(CashierModel cashierModel)
        {
            throw new NotImplementedException();
        }
    }
}
