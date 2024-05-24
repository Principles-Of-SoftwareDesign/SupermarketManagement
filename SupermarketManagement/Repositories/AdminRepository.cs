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

        public void addAdmin(AdminModel adminModel)
        {
            throw new NotImplementedException();
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
                adminModel.Name = reader["name"].ToString();
                adminModel.Email = reader["email"].ToString();
                adminModel.PhoneNumber = reader["phone_number"].ToString();
                admins.Add(adminModel);
            }
            reader.Close();
            connection.Close();

            return admins;
        }
    }
}

