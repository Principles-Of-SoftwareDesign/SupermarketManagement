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
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private dbConnection dbconnection = new dbConnection();
        public AdminRepository()
        {
            this.connection = new MySqlConnection(dbconnection.connect());
        }
        public void EditAdmin(AdminModel adminModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdminModel> GetAllAdmins()
        {
            var admins = new List<AdminModel>();
            connection.Open();
            cmd = new MySqlCommand("SELECT * FROM `users`", connection);
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
            connection.Close();

            return admins;
        }

        public bool addAdmin(AdminModel admin)
        {
            connection.Open();
            var cmd = new MySqlCommand("INSERT INTO users (name, email, phone_number, password, role) VALUES (@Name, @Email, @PhoneNumber, @Password, @Role)", connection);
            cmd.Parameters.AddWithValue("@Name", admin.Name);
            cmd.Parameters.AddWithValue("@Email", admin.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
            cmd.Parameters.AddWithValue("@Password", admin.Password);
            cmd.Parameters.AddWithValue("@Role", admin.Role);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

    }
}

