namespace WarehouseManagementSystem.Domain;

public class Warehouse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Location { get; set; } = default!;
    public ICollection<Item> Items { get; set; } = new HashSet<Item>();
}