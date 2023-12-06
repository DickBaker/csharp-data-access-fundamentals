namespace WarehouseManagementSystem.Infrastructure;

public class CustomerRepository(WarehouseContext context)
        : GenericRepository<Customer>(context)
{
    public override Customer Update(Customer entity)
    {
        Customer toUpdate = Get(entity.Id) ?? throw new KeyNotFoundException("Customer");
        toUpdate.Name = entity.Name;
        toUpdate.Address = entity.Address;
        toUpdate.PostalCode = entity.PostalCode;
        toUpdate.Country = entity.Country;
        toUpdate.PhoneNumber = entity.PhoneNumber;

        return base.Update(toUpdate);
    }
}
