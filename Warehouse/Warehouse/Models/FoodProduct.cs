namespace Warehouse.Models
{
    public class FoodProduct : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public FoodProduct() { }
        public FoodProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"{Name} {Price} {ProductionDate} {ExpirationDate}");
        }
    }
}
