using AddisEats.Api.Models;


namespace AddisEats.Api.Services.RestaurantServices;

public interface IRestaurantService
{
    List<Restaurant> GetAllRestaurants(string? address, int page, int pageSize);
    Restaurant GetById(int id);
}