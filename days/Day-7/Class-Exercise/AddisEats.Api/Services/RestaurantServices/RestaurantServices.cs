using AddisEats.Api.Models;
using AddisEats.Api.Data;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Services.RestaurantServices;

public class RestaurantServices: IRestaurantService
{
    private static readonly List<Restaurant> _Restaurant = new List<Restaurant>();

    private static int _nextId = 1;

    public Restaurant CreateRestaurant(RestaurantDTO createDTO)
    {
        Restaurant r = new Restaurant
        {
            Id = _nextId++,
            Name = createDTO.Name,
            Address = createDTO.Address,
            Phone = createDTO.Phone,
            IsActive = createDTO.IsActive
        };
        _Restaurant.Add(r);
        return r;
    }
}