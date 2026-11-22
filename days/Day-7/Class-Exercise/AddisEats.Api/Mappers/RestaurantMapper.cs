using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Mappers;

public static class RestaurantMapper
{
    public static RestaurantDTO ToDTO(this Restaurant restaurant) //metod name is toDto restrantDto is a return type
    {
        return new RestaurantDTO //new dto
        (
            restaurant.Id,
            restaurant.Name,
            restaurant.Address,
            restaurant.Phone,
            restaurant.IsActive
        );
    }
}
// auto mapper