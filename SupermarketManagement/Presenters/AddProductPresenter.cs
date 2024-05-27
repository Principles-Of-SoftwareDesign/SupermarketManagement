using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class AddProductPresenter
    {
        private readonly IAddProductView view;
        private readonly ProductRepository repository;

        public AddProductPresenter(IAddProductView view)
        {
            this.view = view;
            this.repository = new ProductRepository();  
        }

        public void AddProduct()
        {
            try
            {
                ProductModel product = new ProductModel
                {
                    Name = view.Name,
                    Category = view.Category,
                    Price = view.Price,
                    Quantity = view.Quantity
                };
                repository.AddProduct(product);
                view.ShowMessage("Product added successfully.", "Success");
            }
            catch (Exception ex)
            {
                view.ShowMessage("Error adding product: " + ex.Message, "Error");
            }
        }
    }
}
