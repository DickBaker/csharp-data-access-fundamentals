using System.Text.Json;

namespace WarehouseManagementSystem;

internal static class LocalData
{
    public static IEnumerable<Domain.Order> Load()
    {
        var json = File.ReadAllText("orders.json");

        return JsonSerializer.Deserialize<IEnumerable<Domain.Order>>(json) ?? Enumerable.Empty<Domain.Order>();
    }

    public static void GenerateAndSave()
    {
        Warehouse[] warehouses =
        [
            new() { Location = "Sweden" },
            new() { Location = "USA" }
        ];

        Item[] items =
        [
            new() { Name = "Shure SM7b", InStock = 5,  Price = 399.50m, Description = "Popular microphone for streaming, podcasting and voice over", Warehouses = warehouses},
            new() { Name = "Sennheiser MKH 416", InStock = 3,  Price = 1099.50m, Description = "Professional voice over microphone", Warehouses = warehouses}
                    ];

        ShippingProvider[] shippingProviders =
        [
            new() { Name = "Swedish Postal Service", FreightCost = 10m },
            new() { Name = "United States Postal Service", FreightCost = 5m }
                    ];

        Customer customer = new()
        {
            Name = "Filip Ekberg",
            Address = "Vallda",
            Country = "Sweden",
            PhoneNumber = "+46 555 123 123",
            PostalCode = "434 94"
        };

        Order[] orders =
        [
            new()
            {
                Customer = customer,
                LineItems = new LineItem[]
                {
                    new() { Item = items[0], Quantity = 2 },
                    new() { Item = items[1], Quantity = 1 }
                },
                ShippingProvider = shippingProviders[0]
            },
            new()
            {
                Customer = customer,
                LineItems = new LineItem[]
                {
                    new() { Item = items[0], Quantity = 4 }
                },
                ShippingProvider = shippingProviders[1]
            },
        ];

        var json = JsonSerializer.Serialize(orders);

        File.WriteAllText("orders.json", json);
    }
}
