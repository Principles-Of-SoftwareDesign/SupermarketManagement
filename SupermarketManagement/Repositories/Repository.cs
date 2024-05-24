using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace SupermarketManagement.Repositories
{
    public abstract class Repository
    {
        protected MySqlConnection connection;
    }

}
