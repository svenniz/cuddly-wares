using Warehouse.Factories;
using Warehouse.Models;

namespace Warehouse.Services
{
    /// <summary>
    /// Service class using repository and factory. Handles service layer
    /// ProductController only sees this class.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductFactory _productFactory;
        private readonly FoodProductFactory _foodProductFactory;

        public ProductService(
            IProductRepository productRepository, 
            IProductFactory productFactory, 
            FoodProductFactory foodProductFactory)
        {
            _productRepository = productRepository;
            _productFactory = productFactory;
            _foodProductFactory = foodProductFactory;
        }
        public async Task<IEnumerable<IProduct>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }
        public async Task<IProduct> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }
        public async Task<IProduct> CreateProductAsync(string productType, string name, decimal price)
        {
            IProductFactory factory;

            if (productType.ToLower() == "food")
            {
                factory = _foodProductFactory;
            }
            else
            {
                factory = _productFactory;
            }
            var product = factory.CreateProduct(name, price);
            return await _productRepository.CreateAsync(product);
        }
        public async Task<IProduct> UpdateProductAsync(Product product)
        {
            return await _productRepository.UpdateAsync(product);
        }
        public async Task<bool> DeleteProductAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }
    }
}
