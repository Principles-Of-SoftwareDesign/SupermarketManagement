using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface IViewCashiers
    {
  
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        //Methods (For Forms)
        void setCashiersList(BindingSource cashiersList);
        void ShowMessage(string message, string title);
        void CloseForm();
        void DisplayCashiers(IEnumerable<CashierModel> cashiers);
        //void DisplayCashiers(IEnumerable<CashierModel> cashiers);
    }
}

