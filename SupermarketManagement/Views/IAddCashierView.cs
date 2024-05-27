using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface IAddCashierView
    {
         string Name { get; }
        string Email { get; }
        string PhoneNumber { get; }
        string Password { get; }
        void ShowMessage(string message, string title);
        void CloseForm();
    }
    }

