namespace WarehouseManagementSystem.Domain;

public class LineItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Item Item { get; set; } = default!;
    public int Quantity { get; set; }
}