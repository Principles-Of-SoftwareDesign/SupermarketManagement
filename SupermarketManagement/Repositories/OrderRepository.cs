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


        public bool addOrder(OrderModel order)
        {
            OpenConnection();
            var cmd = new MySqlCommand("INSERT INTO orders (name, price, amount) VALUES (@Name, @Price, @Amount)", connection);
            cmd.Parameters.AddWithValue("@Name", order.Name);
            cmd.Parameters.AddWithValue("@Price", order.Price);
            cmd.Parameters.AddWithValue("@Amount", order.Amount);

            int rowsAffected = cmd.ExecuteNonQuery();
            CloseConnection();

            return rowsAffected > 0;
        }
    }
}
