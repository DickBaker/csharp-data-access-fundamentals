namespace WarehouseManagementSystem.Infrastructure;

public interface IUnitOfWork
{
    IRepository<Customer> CustomerRepository { get;  }
    IRepository<Order> OrderRepository { get; }
    IRepository<Item> ItemRepository { get; }
    IRepository<ShippingProvider> ShippingProviderRepository { get; }

    void SaveChanges();
}

public class UnitOfWork(WarehouseContext context) : IUnitOfWork
{
    private readonly WarehouseContext _context = context;
    private IRepository<Customer> customerRepository = default!;
    public IRepository<Customer> CustomerRepository
    {
        get
        {
            customerRepository ??=
                    new CustomerRepository(_context);
            return customerRepository;
        }
    }

    private IRepository<Order> orderRepository = default!;
    public IRepository<Order> OrderRepository
    {
        get
        {
            orderRepository ??=new OrderRepository(_context);
            return orderRepository;
        }
    }

    private IRepository<Item> itemRepository = default!;
    public IRepository<Item> ItemRepository
    {
        get
        {
            itemRepository ??=new ItemRepository(_context);
            return itemRepository;
        }
    }

    public IRepository<ShippingProvider> shippingProviderRepository = default!;

    public IRepository<ShippingProvider>
        ShippingProviderRepository
    {
        get
        {
            shippingProviderRepository
                    ??= new ShippingProviderRepository(_context);

            return shippingProviderRepository;
        }
    }

    public void SaveChanges() => _context.SaveChanges();
}
