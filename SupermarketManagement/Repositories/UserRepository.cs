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
            throw new NotImplementedException();
        }
    }
}
 