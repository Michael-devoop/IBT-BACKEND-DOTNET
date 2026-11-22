using AddisEats.Api.Models;

using AddisEats.Api.DTOs;

namespace AddisEats.Api.Services.RestaurantServices;

public interface IRestaurantService
{


    Restaurant CreateRestaurant(RestaurantDTO createDTO);
}
