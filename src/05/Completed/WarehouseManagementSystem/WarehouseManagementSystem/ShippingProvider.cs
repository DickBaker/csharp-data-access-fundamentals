﻿namespace WarehouseManagementSystem;

public partial class ShippingProvider
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = null!;
    public decimal FreightCost { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
}
