using System.Linq.Expressions;

namespace WarehouseManagementSystem.Infrastructure;

public abstract class GenericRepository<T>
    : IRepository<T> where T : class
{
    protected WarehouseContext context;

    protected GenericRepository(WarehouseContext context) => this.context = context;

    public virtual T Add(T entity)
    {
        var addedEntity = context.Add(entity).Entity;

        return addedEntity;
    }

    public virtual IEnumerable<T> All()
    {
        var all = context.Set<T>().ToList();

        return all;
    }

    public virtual IEnumerable<T>
        Find(Expression<Func<T, bool>> predicate)
    {
        var result = context.Set<T>().AsQueryable()
            .Where(predicate)
            .ToList();

        return result;
    }

    public virtual T? Get(Guid id) => context.Find<T>(id);

    public virtual void SaveChanges() => context.SaveChanges();

    public virtual T Update(T entity) => context.Update(entity).Entity;
}
