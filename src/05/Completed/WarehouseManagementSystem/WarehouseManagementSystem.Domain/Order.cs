namespace WarehouseManagementSystem.Domain;

public class Order
{
    public Guid Id { get; set; }
    public Customer Customer { get; set; } = default!;
    public ShippingProvider ShippingProvider { get; set; } = default!;
    public ICollection<LineItem> LineItems { get; set; } = new HashSet<LineItem>();
}