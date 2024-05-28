using SupermarketManagement.Models;
using SupermarketManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class InvoicePresenter:IInvoicePresenter
    {
        private IInvoiceView view;
        private List<OrderModel> orders;
        private DiscountFactory discountFactory; 
        private Invoice invoice;

        public InvoicePresenter(Invoice invoice)
        {
            this.invoice = invoice;
            this.discountFactory = new DiscountFactory();
        }

       
        public void ApplyDiscount(string code)
        {
            IDiscount discount = discountFactory.GetDiscount(code);
            if (discount != null)
            {
                discount.CalcDiscount();
                view.ShowDiscountApplied($"Discount applied: {discount.DiscountAmount}");
            }
            else
            {
                view.ShowErrorMessage("Invalid discount code.");
            }
        }
    }
}
