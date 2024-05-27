using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SupermarketManagement.Models;
using SupermarketManagement.Config;


namespace SupermarketManagement.Repositories
{
    public class AdminRepository : Repository, IAdminRepository
    {
       
        public IEnumerable<AdminModel> GetAllAdmins()
        {
            var admins = new List<AdminModel>();
            OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM `users` WHERE role = 1", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var adminModel = new AdminModel();
                adminModel.Id = (int)reader["id"];
                adminModel.Name = reader["name"].ToString();
                adminModel.Email = reader["email"].ToString();
                adminModel.PhoneNumber = reader["phone_number"].ToString();
                admins.Add(adminModel);
            }
            reader.Close();
            CloseConnection();
            return admins;
        }

        public bool addAdmin(AdminModel admin)
        {
            OpenConnection();
            var cmd = new MySqlCommand("INSERT INTO users (name, email, phone_number, password, role) VALUES (@Name, @Email, @PhoneNumber, @Password, @Role)", connection);
            cmd.Parameters.AddWithValue("@Name", admin.Name);
            cmd.Parameters.AddWithValue("@Email", admin.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
            cmd.Parameters.AddWithValue("@Password", admin.Password);
            cmd.Parameters.AddWithValue("@Role", admin.Role);

            int rowsAffected = cmd.ExecuteNonQuery();
            CloseConnection();

            return rowsAffected > 0;
        }

    }
}

