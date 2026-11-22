using AddisEats.Api.Models;



namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuItemService
{
    private readonly List<MenuItem> _menuItems= new()
    {
        new MenuItem { Id = 1, Name = "Burger", Description = "A delicious beef burger", Price = 5.99m, RestaurantId = 1 },
        new MenuItem { Id = 2, Name = "Pizza", Description = "A tasty pepperoni pizza", Price = 10.99m, RestaurantId = 1 },
        new MenuItem { Id = 3, Name = "Pasta", Description = "A classic spaghetti bolognese", Price = 8.99m, RestaurantId = 2 },
        new MenuItem { Id = 4, Name = "Salad", Description = "A fresh garden salad", Price = 4.99m, RestaurantId = 2 },
        new MenuItem { Id = 5, Name = "Sushi", Description = "A selection of fresh sushi rolls", Price = 12.99m, RestaurantId = 3 }
    };

    public List<MenuItem> GetAll()
    {
        return _menuItems;
    }

    public MenuItem? GetById(int id)
    {
        return _menuItems.FirstOrDefault(m => m.Id == id);
    }

    public List<MenuItem> GetByRestaurantId(int? restaurantId, int page = 1, int pageSize = 2)
    {
        var items = _menuItems
         .Where(i => restaurantId==null || i.RestaurantId==restaurantId)
         .OrderBy(i => i.Id)
         .Skip((page - 1) * pageSize)
         .Take(pageSize)
         .ToList();

        return items;



    }
}