using SupermarketManagement.Models;
using System.Collections.Generic;

namespace SupermarketManagement.Repositories
{
    public interface IProductRepository
    {
        bool AddProduct(ProductModel product);
        bool UpdateProduct(ProductModel product);
        bool DeleteProduct(int productId);
        IEnumerable<ProductModel> GetAllProducts();
    }
}
