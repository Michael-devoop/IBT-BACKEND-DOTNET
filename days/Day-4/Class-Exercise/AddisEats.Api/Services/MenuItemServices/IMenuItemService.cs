using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public interface IMenuItemService
{
    List<MenuItem> GetAll();
    MenuItem? GetById(int id);
}