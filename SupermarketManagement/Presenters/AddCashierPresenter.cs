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
    public class AddCashierPresenter
    {
        private IAddCashierView view;
        private ICashierRepository repository;
        private Hashing hashing;

        public AddCashierPresenter(IAddCashierView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.repository = new CashierRepository();
            this.hashing = new Hashing();
        }

        public void addCashier()
        {
            if (string.IsNullOrWhiteSpace(view.Name) ||
                string.IsNullOrWhiteSpace(view.Email) ||
                string.IsNullOrWhiteSpace(view.PhoneNumber) ||
                string.IsNullOrWhiteSpace(view.Password))
            {
                view.ShowMessage("Warning: All fields are required.", "Add Cashier");
                return;
            }

            var cashier = new CashierModel
            {
                Name = view.Name,
                Email = view.Email,
                PhoneNumber = view.PhoneNumber,
                Password = hashing.hashPassword(view.Password)
            };

            if (repository.addCashier(cashier))
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

