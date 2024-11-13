using Warehouse.Models;

namespace Warehouse.Services
{
    /// <summary>
    /// ProductService interface
    /// </summary>
    public interface IProductService
    {
        Task<IProduct> CreateProductAsync(string productType, string name, decimal price);
        Task<bool> DeleteProductAsync(int id);
        Task<IEnumerable<IProduct>> GetAllProductsAsync();
        Task<IProduct> GetProductByIdAsync(int id);
        Task<IProduct> UpdateProductAsync(Product product);
    }
}