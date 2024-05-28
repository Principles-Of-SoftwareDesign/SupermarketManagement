using SupermarketManagement.Models;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using System;

namespace SupermarketManagement.Presenters
{
    public class AddOrderPresenter
    {
        private readonly IAddOrderView view;
        private readonly IOrderRepository repository;

        public AddOrderPresenter(IAddOrderView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.repository = new OrderRepository();
        }

        public void addOrder()
        {
            if (string.IsNullOrWhiteSpace(view.ProductName) ||
                string.IsNullOrWhiteSpace(view.Amount))
            {
                view.ShowMessage("Warning: All fields are required.", "Add Order");
                return;
            }

            if (!decimal.TryParse(view.Amount, out decimal amount))
            {
                view.ShowMessage("Error: Invalid amount format.", "Add Order");
                return;
            }

            decimal price = repository.GetProductPrice(view.ProductName);
            decimal totalPrice = amount * price;

            var order = new Models.SupermarketManagement.Models.addOrderModel()
            {
                Name = view.ProductName,
                Amount = amount,
                TotalPrice = totalPrice
            };

            if (repository.addOrder(order))
            {
                view.CloseForm();
            }
            else
            {
                view.ShowMessage("Error: No rows were affected.", "Add Order");
            }
        }
    }
}
