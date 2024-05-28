using SupermarketManagement.Models;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using System;
using System.Linq;
using System.Windows.Forms;
using SupermarketManagement.Iterators;

namespace SupermarketManagement.Presenters
{
    public class ViewProductPresenter
    {
        private readonly IProductView view;
        private readonly IProductRepository repository;
        private ProductCollection productCollection;

        public ViewProductPresenter(IProductView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.productCollection = new ProductCollection();
        }

        public void LoadProducts()
        {
            var products = repository.GetAllProducts();
            productCollection = new ProductCollection();
            foreach (var product in products)
            {
                productCollection.AddProduct(product);
            }
            view.DisplayProducts(productCollection.GetProducts());
        }

        public void AddProduct()
        {
            try
            {
                ProductModel product = new ProductModel
                {
                    Name = view.ProductName,
                    Category = view.ProductCategory,
                    Price = view.ProductPrice,
                    Quantity = view.ProductQuantity
                };
                repository.AddProduct(product);
                view.ShowMessage("Product added successfully.", "Success");
                LoadProducts();
                view.ClearFields();
            }
            catch (Exception ex)
            {
                view.ShowMessage("Error adding product: " + ex.Message, "Error");
            }
        }

        public void UpdateProduct()
        {
            try
            {
                ProductModel product = new ProductModel
                {
                    Id = int.Parse(view.ProductId),
                    Name = view.ProductName,
                    Category = view.ProductCategory,
                    Price = view.ProductPrice,
                    Quantity = view.ProductQuantity
                };
                repository.UpdateProduct(product);
                view.ShowMessage("Product updated successfully.", "Success");
                LoadProducts();
                view.ClearFields();
            }
            catch (Exception ex)
            {
                view.ShowMessage("Error updating product: " + ex.Message, "Error");
            }
        }

        public void DeleteProduct()
        {
            try
            {
                int productId = int.Parse(view.ProductId);
                repository.DeleteProduct(productId);
                view.ShowMessage("Product deleted successfully.", "Success");
                LoadProducts();
                view.ClearFields();
            }
            catch (Exception ex)
            {
                view.ShowMessage("Error deleting product: " + ex.Message, "Error");
            }
        }

        public void SelectProduct(int rowIndex, DataGridView dataGridView)
        {
            if (rowIndex >= 0)
            {
                view.ProductId = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                view.ProductName = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                view.ProductCategory = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                view.ProductPrice = Convert.ToDouble(dataGridView.Rows[rowIndex].Cells[3].Value);
                view.ProductQuantity = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[4].Value);
            }
        }
    }
}
