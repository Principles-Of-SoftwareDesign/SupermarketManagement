using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    //Dependency Inversion Principle (Depends on abstraction)
    public interface IAdminRepository
    {
        void addAdmin(AdminModel adminModel);
        void EditAdmin(AdminModel adminModel);
        IEnumerable<AdminModel> GetAllAdmins();

    }
}
