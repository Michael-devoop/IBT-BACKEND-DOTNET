using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public interface IMenuItemService
{
    List<MenuItem> GetAll();
    MenuItem? GetById(int id);
    List<MenuItem> GetByRestaurantId(int? restaurantId ,int page=1, int pageSize=2);
}