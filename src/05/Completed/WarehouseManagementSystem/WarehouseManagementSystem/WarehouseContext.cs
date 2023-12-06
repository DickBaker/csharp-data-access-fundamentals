using Microsoft.EntityFrameworkCore;

namespace WarehouseManagementSystem;

public class WarehouseContext
    : DbContext
{
    public DbSet<Customer> Customers { get; set; } = default!;
    public DbSet<Warehouse> Warehouses { get; set; } = default!;
    public DbSet<Item> Items { get; set; } = default!;
    public DbSet<LineItem> LineItems { get; set; } = default!;
    public DbSet<Order> Orders { get; set; } = default!;
    public DbSet<ShippingProvider> ShippingProviders { get; set; } = default!;

    protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // MOVE TO A SECURE PLACE!!!!
        const string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "Initial Catalog=WarehouseManagement;" +
            "Integrated Security=True;";

        optionsBuilder.UseSqlServer(connectionString);
    }
}
