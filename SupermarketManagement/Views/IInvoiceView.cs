using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface IInvoiceView
    {
        void ShowTotalPrice(double totalPrice);
        void ShowDiscountApplied(string discountMessage);
        void ShowErrorMessage(string message);
    }
}
