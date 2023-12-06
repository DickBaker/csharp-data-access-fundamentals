namespace WarehouseManagementSystem.Domain;

public class ShippingProvider
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = default!;
    public decimal FreightCost { get; set; }
}