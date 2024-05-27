using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagement.Models;

namespace SupermarketManagement.Repositories
{
    //Repository Pattern
    public interface IAdminRepository
    {
        bool addAdmin(AdminModel adminModel);
        IEnumerable<AdminModel> GetAllAdmins();

    }
}
