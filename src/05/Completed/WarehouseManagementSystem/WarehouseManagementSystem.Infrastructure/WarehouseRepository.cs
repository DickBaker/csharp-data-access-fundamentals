namespace WarehouseManagementSystem.Infrastructure;

public class WarehouseRepository(WarehouseContext context)
        : GenericRepository<Warehouse>(context)
{
}