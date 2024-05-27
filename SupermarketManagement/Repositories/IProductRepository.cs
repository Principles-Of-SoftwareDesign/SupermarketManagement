using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Repositories
{
    public interface IProductRepository
    {
        public bool AddProduct(ProductModel product);
        public IEnumerable<ProductModel> GetAllProducts();
    }
}
