using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface IAddProductView
    {
        string Name { get; }
        string Category { get; }
        double Price { get; }
        int Quantity { get; }

        void ShowMessage(string message, string title);

        void CloseForm();
    }

}
