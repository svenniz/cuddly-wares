using Warehouse.Models;

namespace Warehouse.Factories
{
    /// <summary>
    /// NYI
    /// </summary>
    public class FoodProductFactory : IProductFactory
    {
        public IProduct CreateProduct(string name, decimal price)
        {
            return new FoodProduct
            {
                Name = name,
                Price = price,
                ProductionDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddDays(30)
            };
        }
    }
}
