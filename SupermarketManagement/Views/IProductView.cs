using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface IProductView
    {
        void DisplayProducts(BindingSource productsList);
        void ShowMessage(string message, string title);
    }
}
