namespace Warehouse.Data.SQLite;

public partial class Warehouse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Location { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();
}
