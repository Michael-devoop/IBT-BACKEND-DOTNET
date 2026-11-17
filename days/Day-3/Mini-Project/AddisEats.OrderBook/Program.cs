using AddisEats.OrderBook.Models;
using AddisEats.OrderBook.Services;

// Create menu items
MenuItem doro = new MenuItem(1, "Doro Wat", "Traditional", 350m);
MenuItem tibs = new MenuItem(2, "Tibs", "Traditional", 450m);
MenuItem pizza = new MenuItem(3, "Pizza", "Fast Food", 300m);

// Create orders
Order order1 = new Order(
    "Michael",
    "Bole",
    new List<OrderLine>
    {
        new OrderLine(doro, 2),
        new OrderLine(tibs, 1)
    }
);

Order order2 = new Order(
    "Abebe",
    "Kazanchis",
    new List<OrderLine>
    {
        new OrderLine(pizza, 3)
    }
);

Order order3 = new Order(
    "Sara",
    "Bole",
    new List<OrderLine>
    {
        new OrderLine(doro, 1)
    }
);

// Create OrderBook
OrderBook book = new OrderBook();

// Add orders
book.AddOrder(order1);
book.AddOrder(order2);
book.AddOrder(order3);

// Display reports
Console.WriteLine("===== ADDIS EATS REPORTS =====");

Console.WriteLine($"Total Revenue: {book.GetTotalRevenue():N2} ETB");

Console.WriteLine($"Busiest Category: {book.GetBusiestCategory()}");

Console.WriteLine("\n===== BOLE ORDERS =====");

book.GetOrdersByArea("Bole").ForEach(order =>
    Console.WriteLine($"{order.Customer}: {order.Total:N2} ETB")
);

Console.WriteLine("\n===== PAGE 1 =====");

book.GetPage(1).ForEach(order =>
    Console.WriteLine($"{order.Customer}: {order.Total:N2} ETB")
);