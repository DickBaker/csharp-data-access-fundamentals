namespace WarehouseManagementSystem;

public partial class Item
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int InStock { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; } = new HashSet<LineItem>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new HashSet<Warehouse>();
}
