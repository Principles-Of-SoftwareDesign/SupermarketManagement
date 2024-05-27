using MySql.Data.MySqlClient;
using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Repositories
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserModel GetUserByEmail(string email)
        {

            UserModel user = null;
            try
            {
                OpenConnection();
                var cmd = new MySqlCommand("SELECT * FROM users WHERE email = @Email", connection);
                cmd.Parameters.AddWithValue("@Email", email);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new UserModel
                        {
                            Email = reader["email"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = Convert.ToInt32(reader["role"])
                        };
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return user;
        }
    }
}
 