using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermarketManagement.Views
{
    public interface IAddAdminView
    {
        string Name { get; }
        string Email { get; }
        string PhoneNumber { get; }
        string Password { get; }
        void ShowMessage(string message, string title);
        void CloseForm();
    }
    
}
