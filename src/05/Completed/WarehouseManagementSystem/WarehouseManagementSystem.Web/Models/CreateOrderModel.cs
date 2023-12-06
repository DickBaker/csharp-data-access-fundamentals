namespace WarehouseManagementSystem.Web.Models;

public class CreateOrderModel
{
    public IEnumerable<LineItemModel> LineItems { get; init; } = [];

    public CustomerModel Customer { get; set; } = default!;
}
