using SupermarketManagement.Models;

namespace SupermarketManagement.Interfaces
{
    public interface IProductCollection
    {
        IIterator CreateIterator();
        void AddProduct(ProductModel product);
        void RemoveProduct(ProductModel product);
        List<ProductModel> GetProducts();
    }
}
