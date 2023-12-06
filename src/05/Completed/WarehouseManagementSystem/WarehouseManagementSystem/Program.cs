﻿
using System.Data;
using Microsoft.Data.SqlClient;

// MOVE TO A SECURE PLACE!!!!
var connectionString =
    "Data Source=(LocalDB)\\MSSQLLocalDB;" +
    "Initial Catalog=WarehouseManagement;" +
    "Integrated Security=True;";

using SqlConnection connection = new(connectionString);

using SqlCommand command = new(@"
    INSERT INTO [Customers]
    (Id, Name, Address, PostalCode, Country, PhoneNumber)
    VALUES(NEWID(), @Name, @Address, @PostalCode, @Country, @PhoneNumber)
", connection);

SqlParameter nameParameter =
    new SqlParameter("Name", SqlDbType.NVarChar)
    {
        Value = Console.ReadLine()?.Trim()
    };
command.Parameters.Add(nameParameter);

SqlParameter addressParameter =
    new SqlParameter("Address", SqlDbType.NVarChar)
    {
        Value = Console.ReadLine()?.Trim()
    };
command.Parameters.Add(addressParameter);

SqlParameter postalCodeParameter =
    new SqlParameter("PostalCode", SqlDbType.NVarChar)
    {
        Value = Console.ReadLine()?.Trim()
    };
command.Parameters.Add(postalCodeParameter);

SqlParameter countryParameter =
    new SqlParameter("Country", SqlDbType.NVarChar)
    {
        Value = Console.ReadLine()?.Trim()
    };
command.Parameters.Add(countryParameter);

SqlParameter phoneNumberParameter =
    new SqlParameter("PhoneNumber", SqlDbType.NVarChar)
    {
        Value = Console.ReadLine()?.Trim()
    };
command.Parameters.Add(phoneNumberParameter);

connection.Open();

var rowsAffected = command.ExecuteNonQuery();

Console.WriteLine($"Rows affected: {rowsAffected}");
Console.ReadLine();

//using SqlCommand command = new(
//    "SELECT * FROM [Orders]" +
//    "INNER JOIN [Customers] ON " +
//    "[Customers].Id = [Orders].CustomerId", connection);

//connection.Open();

//using var reader = command.ExecuteReader();

//if(reader.HasRows == false)
//{
//    return;
//}

//while(reader.Read())
//{
//    var orderId = reader["Id"];
//    var customer = reader["Name"];

//    Console.WriteLine(orderId);
//    Console.WriteLine(customer);
//}

//Console.ReadLine();

//using Microsoft.EntityFrameworkCore;
//using WarehouseManagementSystem;

//Customer filip = new()
//{
//    Name = "Filip Ekberg",
//    Address = "Kungsbacka",
//    PostalCode = "434 94",
//    Country = "Sweden",
//    PhoneNumber = "+46 111 111 111"
//};

//ShippingProvider shippingProvider = new()
//{
//    Name = "Swedish Postal Service",
//    FreightCost = 100m
//};

//Item item = new()
//{
//    Name = "Shure SM7b",
//    Description = "Microphone",
//    InStock = 5,
//    Price = 999,
//    Warehouses = new WarehouseManagementSystem.Warehouse[] 
//    { 
//        new () { Location = "Sweden" }
//    }
//};

//Order order = new()
//{
//    Customer = filip,
//    ShippingProvider = shippingProvider,
//    LineItems = new LineItem[]
//    {
//        new()
//        {
//            Item = item,
//            Quantity = 1
//        }
//    }
//};
//order.LineItems.Add(new());
//using var context = new WarehouseContext();
//context.Database.Migrate();

//context.Orders.Add(order);
//context.SaveChanges();

////using Microsoft.EntityFrameworkCore;
////using Warehouse.Data.SQLite;
////using WarehouseManagementSystem;
////using Order = Warehouse.Data.SQLite.Order;
////using LineItem = Warehouse.Data.SQLite.LineItem;
////using Customer = Warehouse.Data.SQLite.Customer;
////using Item = Warehouse.Data.SQLite.Item;
////using ShippingProvider = Warehouse.Data.SQLite.ShippingProvider;
////using Warehouse = Warehouse.Data.SQLite.Warehouse;

////using var context = new WarehouseSQLiteContext();

////var firstCustomer = context.Customers.First();
////Order newOrder = new()
////{
////    LineItems = new LineItem[]
////    {
////        new()
////        {
////            Item = context.Items.First(),
////            Quantity = 1
////        }
////    },
////    ShippingProvider = context.ShippingProviders.First(),
////    Customer = firstCustomer
////};

////context.Orders.Add(newOrder);
////context.SaveChanges();
////Console.WriteLine("Order added!");

////Console.ReadLine();

////Console.Write("Enter customer name: ");

////var newCustomer = new Customer
////{
////    Name = Console.ReadLine(),
////    Address = "Kungsbacka",
////    PostalCode = "434 94",
////    Country = "Sweden",
////    PhoneNumber = "+46 111 111 11"
////};

////context.Customers.Add(newCustomer);

////context.SaveChanges();

////var toUpdate = context.Customers
////    .First(customer => customer.Name == "Filip Ekberg (1)");

////toUpdate.Name = "Sofie Ekberg";

////context.Customers.Update(toUpdate);

////context.SaveChanges();

////Console.ReadLine();

////var customer = context.Customers
////    .FirstOrDefault(customer => customer.Name == "Filip Ekberg");

////foreach(var order in 
////    context.Orders
////    .Where(order => order.CustomerId == customer.Id)
////    .Include(order => order.Customer)
////    .Include(order => order.ShippingProvider)
////    .Include(order => order.LineItems)
////    .ThenInclude(lineItem => lineItem.Item))
////{
////    Console.WriteLine($"Order Id: {order.Id}");
////    Console.WriteLine($"Customer: {order.Customer.Name}");
////    Console.WriteLine($"Shipping Provider: {order.ShippingProvider.Name}");
////    foreach (var lineItem in order.LineItems)
////    {
////        Console.WriteLine($"\t{lineItem.Item.Name}");
////        Console.WriteLine($"\t{lineItem.Item.Price}");
////    }
////}

////Console.ReadLine();