using SupermarketManagement.Interfaces;
using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Iterators
{
    public class ProductCollection : IProductCollection
    {
        private List<ProductModel> products = new List<ProductModel>();

        public IIterator CreateIterator()
        {
            return new ProductIterator(this);
        }

        public void AddProduct(ProductModel product)
        {
            products.Add(product);
        }

        public void RemoveProduct(ProductModel product)
        {
            products.Remove(product);
        }

        public List<ProductModel> GetProducts()
        {
            return products;
        }
    }

}