using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface ILoginView
    {
        string Email { get; }
        string Password { get; }
        void ShowMessage(string message);
        void OpenAdminView();
        void OpenCategoryView();
        void ClearForm();
    }
}
