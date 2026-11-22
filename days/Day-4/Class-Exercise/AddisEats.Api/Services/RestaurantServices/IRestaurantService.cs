using AddisEats.Api.Models;

namespace AddisEats.Api.Services.RestaurantServices;

public interface IRestaurantService
{
    List<Restaurant> GetAll();
    Restaurant? GetById(int id);
}
