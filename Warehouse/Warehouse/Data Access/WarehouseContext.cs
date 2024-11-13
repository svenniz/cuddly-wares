using Microsoft.EntityFrameworkCore;
using Warehouse.Models;

namespace Warehouse.Data_Access
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
