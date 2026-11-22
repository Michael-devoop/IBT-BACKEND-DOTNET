using AddisEats.Api.Models;
using AddisEats.Api.DTOs;
using AddisEats.Api.Data;




namespace AddisEats.Api.Services.RestaurantServices;

public class RestaurantService : IRestaurantService
{
    private static readonly List<Restaurant> allRestaurants = SeedData.restaurants;

  
    public List<Restaurant> GetAllRestaurants(string? address, int page, int pageSize)
    {
        var restaurants = allRestaurants 
            .Where(r=> address == null || r.Address==address)
            .OrderBy(r => r.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return restaurants;
    }
    public Restaurant GetById(int id)
    {
        return allRestaurants.FirstOrDefault(r => r.Id == id);
    }
}