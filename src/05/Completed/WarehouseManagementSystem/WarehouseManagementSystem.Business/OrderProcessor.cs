using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business;

public static class OrderProcessor
{
    private static void Initialize(Order order) =>
        Console.WriteLine($"Initializing Order with Order Number: {order.Id}");

    public static void Process(Order order)
    {
        Initialize(order);

        Console.WriteLine($"Finalizing Order Processing for Order Number: {order.Id}");
    }
}