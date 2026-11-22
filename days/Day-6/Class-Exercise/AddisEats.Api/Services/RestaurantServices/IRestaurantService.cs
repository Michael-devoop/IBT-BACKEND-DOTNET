using AddisEats.Api.Models;
using AddisEats.Api.DTOs;


namespace AddisEats.Api.Services.RestaurantServices;

public interface IRestaurantService
{
    PaginatedResultDTO<RestaurantDTO> GetAllRestaurants(RestaurantQuery query);
    Restaurant GetById(int id);
    List<Restaurant> GetAllActive();
}