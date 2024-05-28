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
        private readonly IInvoiceView view;
        private readonly List<ProductModel> products;
        private readonly IDiscountHandlerFactory discountFactory;

        public InvoicePresenter(IInvoiceView view, IDiscountHandlerFactory discountFactory)
        {
            this.view = view;
            products = new List<ProductModel>();
            this.discountFactory = discountFactory;
        }

        public void CalculateTotalPrice()
        {
            double totalPrice = products.Sum(p => p.Price);
            view.ShowTotalPrice(totalPrice);
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
