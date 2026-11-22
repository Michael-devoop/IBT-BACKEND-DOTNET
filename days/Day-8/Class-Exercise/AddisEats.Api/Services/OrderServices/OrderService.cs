using AddisEats.Api.DTOs;
using AddisEats.Api.Models;
using AddisEats.Api.Common;
using AddisEats.Api.Services.RestaurantServices;

namespace AddisEats.Api.Services.OrderServices;

public class OrderService : IOrderService
{
    private static readonly List<Order> _order = new List<Order>();
    private static int _nextId = 1;

    private readonly IRestaurantService _restaurantService;

    public OrderService(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    public Order? GetById(int id)
    {
        return _order.FirstOrDefault(o => o.Id == id);
    }

    public Result<Order> CreateOrder(CreateOrderDTO createDTO)
    {
        var restaurant = _restaurantService.GetById(createDTO.RestaurantId);
        if (restaurant is null)
        {
            return Result<Order>.Fail("RESTAURANT_NOT_FOUND", "the selected restaurant is not found.",404);
        }
        //if (!restaurant.IsActive)
        //{
        //    return Result<Order>.Fail("RESTAURANT_NOT_ACTIVE", "teh selected restaurant is not active.")
        //}

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
        return Result<Order>.Ok(o);
    }

}