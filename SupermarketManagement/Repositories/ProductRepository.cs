using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SupermarketManagement.Models;
using SupermarketManagement.Config;

namespace SupermarketManagement.Repositories
{
    public class ProductRepository : Repository
    {
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private dbConnection dbconnection = new dbConnection();
        private MySqlConnection connection;

        public ProductRepository()
        {
            this.connection = new MySqlConnection(dbconnection.connect());
        }

        public bool AddProduct(ProductModel product)
        {
            try
            {
                connection.Open();
                cmd = new MySqlCommand("INSERT INTO products (name, category, price, quantity) VALUES (@Name, @Category, @Price, @Quantity)", connection);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Adding Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            var products = new List<ProductModel>();
            try
            {
                connection.Open();
                cmd = new MySqlCommand("SELECT * FROM `products`", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var product = new ProductModel
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Category = reader["category"].ToString(),
                        Price = Convert.ToDouble(reader["price"]),
                        Quantity = Convert.ToInt32(reader["quantity"])
                    };
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Retrieving Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
                connection?.Close();
            }
            return products;
        }
    }
}
