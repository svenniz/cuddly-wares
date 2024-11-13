namespace Warehouse.Models
{
    /// <summary>
    /// Concrete product (Could be called DefaultProduct or GeneralProduct instead)
    /// </summary>
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product() { }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"{Name} {Price}");
        }
    }
}
