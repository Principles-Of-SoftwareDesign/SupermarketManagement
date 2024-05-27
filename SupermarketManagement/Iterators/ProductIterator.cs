using SupermarketManagement.Interfaces;
using SupermarketManagement.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Iterators
{
    public class ProductIterator : IIterator
    {
        private ProductCollection collection;
        private int currentIndex = 0;

        public ProductIterator(ProductCollection collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return currentIndex < collection.GetProducts().Count;
        }

        public object Next()
        {
            return collection.GetProducts()[currentIndex++];
        }
    }
}