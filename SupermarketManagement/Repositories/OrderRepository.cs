using MySql.Data.MySqlClient;
using SupermarketManagement.Config;
using SupermarketManagement.Models;
using SupermarketManagement.Models.SupermarketManagement.Models;
using System;
using System.Collections.Generic;

namespace SupermarketManagement.Repositories
{
    public class OrderRepository : Repository, IOrderRepository
    {
        public bool addOrder(addOrderModel order)
        {
            connection.Open();
            var cmd = new MySqlCommand("INSERT INTO orders (name, amount, TotalPrice) VALUES (@Name, @Amount, @TotalPrice)", connection);
            cmd.Parameters.AddWithValue("@Name", order.Name);
            cmd.Parameters.AddWithValue("@Amount", order.Amount);
            cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

        public List<ProductModel> LoadProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            connection.Open();
            var cmd = new MySqlCommand("SELECT name, price FROM products", connection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var product = new ProductModel
                    {
                        Name = reader.GetString("name"),
                        Price = (double)reader.GetDecimal("price")  
                    };
                    products.Add(product);
                }
            }
            connection.Close();
            return products;
        }

        public decimal GetProductPrice(string productName)
        {
            decimal price = 0;
            connection.Open();
            var cmd = new MySqlCommand("SELECT price FROM products WHERE name = @Name", connection);
            cmd.Parameters.AddWithValue("@Name", productName);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    price = reader.GetDecimal("price");
                }
            }
            connection.Close();
            return price;
        }

        public bool AddCashier(CashierModel cashierModel)
        {
            throw new NotImplementedException();
        }


        List<string> IOrderRepository.LoadProducts()
        {
            throw new NotImplementedException();
        }
    }

}
