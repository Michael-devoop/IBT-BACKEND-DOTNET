using AddisEats.Api.Models;



namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuItemService
{
   

    public List<MenuItem> GetAll()
    {
        return _menuItems;
    }

    public MenuItem? GetById(int id)
    {
        return _menuItems.FirstOrDefault(m => m.Id == id);
    }
}