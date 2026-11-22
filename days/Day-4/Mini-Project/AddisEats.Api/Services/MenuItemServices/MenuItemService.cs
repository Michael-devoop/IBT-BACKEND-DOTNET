using AddisEats.Api.Models;



namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuItemService
{

    private readonly List<MenuItem> _menuItems= new()
    {
        new MenuItem { Id = 1, Name = "Burger", Description = "A delicious beef burger", Price = 5.99m },
        new MenuItem { Id = 2, Name = "Pizza", Description = "A tasty pepperoni pizza", Price = 10.99m },
        new MenuItem { Id = 3, Name = "Pasta", Description = "A classic spaghetti bolognese", Price = 8.99m },
        new MenuItem { Id = 4, Name = "Salad", Description = "A fresh garden salad", Price = 4.99m },
        new MenuItem { Id = 5, Name = "Sushi", Description = "A selection of fresh sushi rolls", Price = 12.99m }
    };
    private static int _nextId;

    public List<MenuItem> GetAll()
    {
        return _menuItems;
    }

    public MenuItem? GetById(int id)
    {
        return _menuItems.FirstOrDefault(m => m.Id == id);
    }
    public MenuItem CreateMenuItem(MenuItem create)
    {        
            var menuitem = new MenuItem
            {
                Id = _nextId++,
                Name = create.Name,
                Description = create.Description,
                Price = create.Price
            };
              _menuItems.Add(menuitem);
               return menuitem;

    }
}