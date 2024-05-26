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
    public class AddAdminPresenter
    {

        private IAddAdminView view;
        private IAdminRepository repository;
        private Hashing hashing;

        public AddAdminPresenter(IAddAdminView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.repository = new AdminRepository();
            this.hashing = new Hashing();
        }

        public void addAdmin()
        {
            if (string.IsNullOrWhiteSpace(view.Name) ||
                string.IsNullOrWhiteSpace(view.Email) ||
                string.IsNullOrWhiteSpace(view.PhoneNumber) ||
                string.IsNullOrWhiteSpace(view.Password))
            {
                view.ShowMessage("Warning: All fields are required.", "Add Admin");
                return;
            }

            var admin = new AdminModel
            {
                Name = view.Name,
                Email = view.Email,
                PhoneNumber = view.PhoneNumber,
                Password = hashing.hashPassword(view.Password)
            };

            if (repository.addAdmin(admin))
            {
                view.CloseForm();
            }
            else
            {
                view.ShowMessage("Error: No rows were affected.", "Add Admin");
            }
        }
    }
}
