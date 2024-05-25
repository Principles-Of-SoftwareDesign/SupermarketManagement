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
        void addAdmin(AdminModel adminModel);
        void EditAdmin(AdminModel adminModel);

        IEnumerable<AdminModel> GetAllAdmins();

    }
}
