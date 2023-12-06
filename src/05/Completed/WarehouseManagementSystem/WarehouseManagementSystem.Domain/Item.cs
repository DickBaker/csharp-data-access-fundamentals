namespace WarehouseManagementSystem.Domain;

public class Item
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public ICollection<Warehouse> Warehouses { get; set; } = new HashSet<Warehouse>();
}