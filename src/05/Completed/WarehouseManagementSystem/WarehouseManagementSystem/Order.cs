namespace WarehouseManagementSystem;

public partial class Order
{
    public Order() => LineItems = new HashSet<LineItem>();

    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CustomerId { get; set; }
    public Guid ShippingProviderId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;
    public virtual ShippingProvider ShippingProvider { get; set; } = null!;
    public virtual ICollection<LineItem> LineItems { get; set; }
}
