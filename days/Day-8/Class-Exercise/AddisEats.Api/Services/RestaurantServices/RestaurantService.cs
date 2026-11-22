using AddisEats.Api.Models;
using AddisEats.Api.DTOs;
using AddisEats.Api.Data;
using AddisEats.Api.Mapper;
using AddisEats.Api.Services.RestaurantServices;




namespace AddisEats.Api.Services.RestaurantServices;

public class RestaurantService : IRestaurantService
{
    private static readonly List<Restaurant> allRestaurants = SeedData.restaurants;

  
    public PaginatedResultDTO<RestaurantDTO> GetAllRestaurants(RestaurantQuery query)
    {
       
        var restaurants = allRestaurants 
            .Where(r=> query.Address == null || r.Address==query.Address)
            .OrderBy(r => r.Id)
            .ToList();
        var totalCount = restaurants.Count;
        var toReturn = restaurants
            .Skip((query.Page - 1) * query.PageSize)
            .Take(query.PageSize)
            .ToList();


         PaginatedResultDTO<RestaurantDTO> resultDTO = new PaginatedResultDTO<RestaurantDTO>
        {
            TotalCount = totalCount,
            Page = query.Page,
            PageSize = query.PageSize,
            Data = toReturn.Select(r=> r.ToDTO()).ToList()
            
        };
        return resultDTO;
    }
    public Restaurant GetById(int id)
    {
        return allRestaurants.FirstOrDefault(r => r.Id == id);
    }
    public List<Restaurant> GetAllActive()
    {
        var restaurants = allRestaurants
            .Where(r => r.IsActive == true)
            .OrderBy(r => r.Id)
            .ToList();
        return restaurants;

    }
}