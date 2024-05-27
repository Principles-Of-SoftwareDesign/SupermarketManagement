using SupermarketManagement.Models;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class AddOrderPresenter
    {
        private IAddOrderView view;
        private IOrderRepository repository;

        public AddOrderPresenter(IAddOrderView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.repository = new OrderRepository();
        }

        public void addOrder()
        {
            if (string.IsNullOrWhiteSpace(view.Name) ||
                string.IsNullOrWhiteSpace(view.amount) ||
                string.IsNullOrWhiteSpace(view.price))
            {
                view.ShowMessage("Warning: All fields are required.", "Add Cashier");
                return;
            }

            var order = new addOrderModel
            {
                Name = view.Name,
                
            };

            if (repository.addOrder(order))
            {
                view.CloseForm();
            }
            else
            {
                view.ShowMessage("Error: No rows were affected.", "Add cashier");
            }
        }
    }
}

