
decimal DeliveryFee(string area, bool isVip = false)
{
    if (isVip)
    {
        return 0m;
    }

    return area switch
    {
        "Bole" => 60m,
        "Piassa" => 80m,
        "Megenagna" => 50m,
        "Kazanchis" => 40m,
        _ => 100m
    };
}

// 1. Positional argument
decimal fee1 = DeliveryFee("Bole");

// 2. Named argument
decimal fee2 = DeliveryFee("Piassa", isVip: true);

// 3. Using the default value (isVip = false)
decimal fee3 = DeliveryFee("Megenagna");

Console.WriteLine($"Bole delivery fee: {fee1} ETB");
Console.WriteLine($"Piassa VIP delivery fee: {fee2} ETB");
Console.WriteLine($"Megenagna delivery fee: {fee3} ETB");

/*------------------------------------------*/

void Describe(int value)
{
    Console.WriteLine("Integer method chosen");
}

void Describe(string value)
{
    Console.WriteLine("String method chosen");
}

void Describe(decimal value)
{
    Console.WriteLine("Decimal method chosen");
}


Describe(10);
Describe("Yod Abyssinia");
Describe(480.50m);

/*------------------------------------------*/

class Restaurant
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string Area { get; set; }

    public string DisplayName
    {
        get
        {
            return $"{Name} ({Area})";
        }
    }
}

/*------------------------------------------*/

record Customer(string Name, string Phone);
Customer customer1 = new Customer("Michael", "0911234567");
Customer customer2 = new Customer("Michael", "0911234567");

Console.WriteLine(customer1 == customer2);
/*------------------------------------------*/
class Order
{
    public string CustomerName { get; set; }
    public string Area { get; set; }
    public decimal Total { get; set; }
    public DateTime OrderDate { get; set; }
}


List<Order> orders = new List<Order>
{
    new Order { CustomerName = "Michael", Area = "Bole", Total = 600, OrderDate = DateTime.Now },
    new Order { CustomerName = "Abebe", Area = "Kazanchis", Total = 800, OrderDate = DateTime.Now.AddDays(-1) },
    new Order { CustomerName = "Sara", Area = "Bole", Total = 450, OrderDate = DateTime.Now.AddDays(-2) },
    new Order { CustomerName = "Dawit", Area = "Kazanchis", Total = 700, OrderDate = DateTime.Now.AddDays(-3) }
};


var boleOrders = orders
    .Where(o => o.Area == "Bole" && o.Total > 500)
    .ToList();


var customerNames = orders
    .Select(o => o.CustomerName)
    .OrderBy(name => name)
    .ToList();


var kazanchisRevenue = orders
    .Where(o => o.Area == "Kazanchis")
    .Sum(o => o.Total);


var page3 = orders
    .OrderByDescending(o => o.OrderDate)
    .Skip(20)
    .Take(10)
    .ToList();
