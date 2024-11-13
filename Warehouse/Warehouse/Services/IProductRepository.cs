using Warehouse.Models;

namespace Warehouse.Services
{
    /// <summary>
    /// Interface for productRepository
    /// </summary>
    public interface IProductRepository
    {
        Task<IEnumerable<IProduct>> GetAllAsync();
        Task<IProduct> GetByIdAsync(int id);
        Task<IProduct> CreateAsync(Product product);
        Task<IProduct> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<IProduct> CreateAsync(IProduct product);
    }
}
