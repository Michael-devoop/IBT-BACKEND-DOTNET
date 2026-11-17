using AddisEats.OrderBook.Models;

namespace AddisEats.OrderBook.Services;

public class OrderBook
{
    private List<Order> orders = new List<Order>();
    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public List<Order> GetOrdersByArea(string area)
    {
        return orders
            .Where(order => order.Area == area)
            .OrderByDescending(order => order.Total)
            .ToList();
    }

    public decimal GetTotalRevenue()
    {
        return orders.Sum(order => order.Total);
    }

    public string GetBusiestCategory()
    {
        return orders
            .SelectMany(order => order.Lines)
            .GroupBy(line => line.Item.Category)
            .OrderByDescending(group => group.Sum(line => line.Quantity))
            .Select(group => group.Key)
            .FirstOrDefault() ?? "No orders";
    }
    
    public List<Order> GetPage(int pageNumber)
    {
        if (pageNumber <= 0)
        {
            throw new ArgumentException("Page number must be positive.");
        }
        return orders
            .OrderByDescending(order => order.Total)
            .Skip((pageNumber - 1) * 5)
            .Take(5)
            .ToList();
    }
}