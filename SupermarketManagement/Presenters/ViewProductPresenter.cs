/*using System;
using System.Collections.Generic;
using SupermarketManagement.Models; 
using SupermarketManagement.Repositories; 
using SupermarketManagement.Views;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class ViewProductsPresenter
    {
        private readonly IViewProductView view;
        private readonly ProductRepository repository;

        public ViewProductsPresenter(IViewProductsView view, ProductRepository repository)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            LoadProducts();
        }

        public void LoadProducts()
        {
            try
            {
                var products = repository.GetAllProducts();
                view.DisplayProducts(products);
            }
            catch (Exception ex)
            {
                view.ShowMessage("Failed to load products: " + ex.Message, "Error");
            }
        }
    }
}
*/