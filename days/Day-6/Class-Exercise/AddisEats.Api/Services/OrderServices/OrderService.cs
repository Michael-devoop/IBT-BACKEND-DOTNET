using AddisEats.Api.DTOs;
using AddisEats.Api.Models;

namespace AddisEats.Api.Services.OrderServices;

public class OrderService : IOrderService
{
    private static readonly List<Order> _order = new List<Order>();
    private static int _nextId = 1;

    public Order? GetById(int id)
    {
        return _order.FirstOrDefault(o => o.Id == id);
    }

    public Order CreateOrder(CreateOrderDTO createDTO)
    {
        Order o = new Order
        {
            Id = _nextId++,
            RestaurantId = createDTO.RestaurantId,
            MenuItemId = createDTO.MenuItemId,
            CustomerName = createDTO.CustomerName,
            DeliveryAddress = createDTO.DeliveryAddress,
            CustomerPhone = createDTO.CustomerPhone,
            Quantity = createDTO.Quantity,
            TotalAmount = createDTO.TotalAmount
        };
        _order.Add(o);
        return o;
    }

}