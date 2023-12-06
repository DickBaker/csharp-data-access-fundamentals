using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace WarehouseManagementSystem.Infrastructure;

public class OrderRepository(WarehouseContext context)
        : GenericRepository<Order>(context)
{
    public override IEnumerable<Order>
        Find(Expression<Func<Order, bool>> predicate) => context.Orders
            .Include(order => order.LineItems)
            .ThenInclude(lineItem => lineItem.Item)
            .Where(predicate)
            .ToList();

    public override Order Update(Order entity)
    {
        Order toUpdate = context.Orders
            .Include(order => order.LineItems)
            .ThenInclude(lineItem => lineItem.Item)
            .Single(order => order.Id == entity.Id);

        toUpdate.CreatedAt = entity.CreatedAt;
        toUpdate.LineItems = entity.LineItems;

        return base.Update(toUpdate);
    }
}