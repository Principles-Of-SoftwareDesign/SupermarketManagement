using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SupermarketManagement.Config;
using SupermarketManagement.Models;

namespace SupermarketManagement.Repositories
{
    public class ProductRepository : Repository, IProductRepository
    {
        public IEnumerable<ProductModel> GetAllProducts()
        {
            var products = new List<ProductModel>();
            OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM `products`", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var product = new ProductModel();
                product.Id = (int)reader["id"];
                product.Name = reader["name"].ToString();
                product.Category = reader["category"].ToString();
                product.Price = Convert.ToDouble(reader["price"]);
                product.Quantity = (int)reader["quantity"];
                products.Add(product);
            }
            reader.Close();
            CloseConnection();

            return products;
        }

        public bool AddProduct(ProductModel product)
        {
            OpenConnection();
            cmd = new MySqlCommand("INSERT INTO `products`(`name`, `category`, `price`, `quantity`) VALUES (@name, @category, @price, @quantity)", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@category", product.Category);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@quantity", product.Quantity);
            int i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i > 0;
        }

        public bool UpdateProduct(ProductModel product)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE `products` SET `name`=@name, `category`=@category, `price`=@price, `quantity`=@quantity WHERE `id`=@id", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@category", product.Category);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@quantity", product.Quantity);
            int i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i > 0;
        }

        public bool DeleteProduct(int productId)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `products` WHERE `id`=@id", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", productId);
            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }
    }
}
