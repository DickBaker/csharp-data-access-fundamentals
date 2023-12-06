namespace WarehouseManagementSystem.Infrastructure;

public class ItemRepository(WarehouseContext context) : GenericRepository<Item>(context)
{
    public override Item Update(Item entity)
    {
        Item toUpdate = Get(entity.Id) ?? throw new KeyNotFoundException("Item");
        toUpdate.Price = entity.Price;
        toUpdate.Name = entity.Name;

        return base.Update(toUpdate);
    }
}
