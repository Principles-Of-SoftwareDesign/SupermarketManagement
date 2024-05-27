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
    public class CategoryRepository : Repository , ICategoryRepository
    {
        public bool AddCategory(CategoryModel category)
        {
            OpenConnection();
            cmd = new MySqlCommand("INSERT INTO `category`(`category_id`, `name`) VALUES (@category_id, @name)", connection);
            //cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@category_id", category.CategoryID);
            cmd.Parameters.AddWithValue("@name", category.Name);
            int i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i > 0;
        }

    }
}
