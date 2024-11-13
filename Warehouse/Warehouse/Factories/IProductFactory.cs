using Warehouse.Models;

namespace Warehouse.Factories
{
    /// <summary>
    /// Factory interface
    /// </summary>
    public interface IProductFactory
    {
        IProduct CreateProduct(string name, decimal price);
    }
}