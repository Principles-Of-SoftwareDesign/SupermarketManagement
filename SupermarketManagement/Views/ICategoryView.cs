using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface ICategoryView
    {
        void DisplayCategories(IEnumerable<CategoryModel> categories);
        string CategoryId { get; set; }
        string CategoryName { get; set; }
        void ShowMessage(string message, string title);
        void ClearFields();
    }
}
