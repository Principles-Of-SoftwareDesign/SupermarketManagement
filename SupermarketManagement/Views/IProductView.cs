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
        void DisplayProducts(IEnumerable<ProductModel> products);
        void ShowMessage(string message, string title);
        void ClearFields();

        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductCategory { get; set; }
        double ProductPrice { get; set; }
        int ProductQuantity { get; set; }
    }
}
