using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly IUserRepository repository;
        private readonly Hashing hashing;

        public LoginPresenter(ILoginView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.repository = new UserRepository();
            this.hashing = new Hashing();
        } 

        public void Login()
        {
            var user = repository.GetUserByEmail(view.Email);
            if (string.IsNullOrWhiteSpace(view.Email) ||
                string.IsNullOrWhiteSpace(view.Password)){
                view.ShowMessage("The username and password you entered are incorrect. Try again");
                view.ClearForm();
                return;
            }


            if (hashing.VerifyPassword(view.Password, user.Password))
            {
                if (user.Role == 1)
                {
                    view.OpenAdminView();
                }
                else
                {
                    view.OpenCategoryView();
                }
            }
            else
            {
                view.ShowMessage("The password you entered is incorrect. Try again.");
                view.ClearForm();
            }
        }
    }
}
