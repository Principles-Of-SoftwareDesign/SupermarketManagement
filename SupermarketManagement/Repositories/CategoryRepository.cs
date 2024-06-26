﻿using System;
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
        public IEnumerable<CategoryModel> GetAllCategories()
        {
            var categories = new List<CategoryModel>();
            OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM `category`", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var category = new CategoryModel();
                category.Id = (int)reader["id"];
                category.CategoryID = (int)reader["category_id"];
                category.Name = reader["name"].ToString();
                categories.Add(category);

                //categories.Add(new CategoryModel
                //{
                //    CategoryId = int.Parse(reader["category_id"].ToString()),
                //    Name = reader["name"].ToString()
                //});
            }
            reader.Close();
            CloseConnection();

            return categories;
        }
        public bool AddCategory(CategoryModel category)
        {
            OpenConnection();
            cmd = new MySqlCommand("INSERT INTO `category`(`category_id`, `name`) VALUES (@category_id, @name)", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@category_id", category.CategoryID);
            cmd.Parameters.AddWithValue("@name", category.Name);
            int i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i > 0;
        }
        public bool UpdateCategory(CategoryModel category)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE `category` SET `name`=@name WHERE `category_id`=@category_id", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@category_id", category.CategoryID);
            cmd.Parameters.AddWithValue("@name", category.Name);
            int i = cmd.ExecuteNonQuery();
            CloseConnection();
            return i > 0;
        }
        public bool DeleteCategory(int categoryId)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `category` WHERE `category_id`=@category_id", connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@category_id", categoryId);
            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

    }
}
