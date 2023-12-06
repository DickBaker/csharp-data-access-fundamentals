namespace WarehouseManagementSystem.Infrastructure;

public class ShippingProviderRepository(WarehouseContext context)
        : GenericRepository<ShippingProvider>(context)
{
}
