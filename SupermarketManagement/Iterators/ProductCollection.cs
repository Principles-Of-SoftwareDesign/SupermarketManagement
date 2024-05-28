using SupermarketManagement.Interfaces;
using SupermarketManagement.Models;
using System.Collections.Generic;

namespace SupermarketManagement.Iterators
{
    public class ProductCollection : IProductCollection
    {
        private readonly List<ProductModel> _products = new List<ProductModel>();

        public IIterator CreateIterator()
        {
            return new ProductIterator(this);
        }

        public void AddProduct(ProductModel product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(ProductModel product)
        {
            _products.Remove(product);
        }

        public List<ProductModel> GetProducts()
        {
            return _products;
        }
    }
}
