using Warehouse.Models;

namespace Warehouse.Factories
{
    /// <summary>
    /// Concrete Factory Class
    /// </summary>
    public class ProductFactory : IProductFactory
    {
        /// <summary>
        /// Concrete factory method. Creates product with name and price.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="price">price</param>
        /// <returns>product with name and price</returns>
        public IProduct CreateProduct(string name, decimal price)
        {
            return new Product { Name = name, Price = price };
        }
    }
}
