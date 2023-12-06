namespace WarehouseManagementSystem.Web.Models;

public class LineItemModel
{
    public Guid ItemId { get; set; } = Guid.NewGuid();
    public int Quantity { get; set; }
}