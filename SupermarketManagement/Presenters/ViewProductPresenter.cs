using System;
using SupermarketManagement.Models;
using SupermarketManagement.Repositories;
using System.Windows.Forms;
using SupermarketManagement.Views;

namespace SupermarketManagement.Presenters
{
    public class ViewProductPresenter
    {
        private IProductView view;
        private ProductRepository productRepository;

        public ViewProductPresenter(IProductView view)
        {
            this.view = view;
            this.productRepository = new ProductRepository();
        }

        public void LoadProducts()
        {
            try
            {
                var products = productRepository.GetAllProducts();
                BindingSource source = new BindingSource();
                source.DataSource = products;
                view.DisplayProducts(source);
            }
            catch (Exception ex)
            {
                view.ShowMessage("Failed to load products: " + ex.Message, "Error");
            }
        }
    }

}
