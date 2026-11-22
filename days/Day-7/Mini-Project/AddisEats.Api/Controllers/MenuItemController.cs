using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.MenuItemServices;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/menu-items")]

public class MenuItemController : ControllerBase
{
    private readonly IMenuItemService _menuItemService;
    public MenuItemController(IMenuItemService menuItemService)
    {
        _menuItemService = menuItemService;
    }



    [HttpGet()]
    public IActionResult GetAll()
    {
        var result = _menuItemService.GetAll();
        return Ok(result);
    }
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var result = _menuItemService.GetById(id);
        return   Ok(result);
    }
    [HttpGet("/api/v1/restaurants/menu-items")]
    public IActionResult GetByrestaurantId([FromQuery]int restaurantId, [FromQuery] int page = 1, [FromQuery] int pageSize = 2)
    {
        var result = _menuItemService.GetByRestaurantId(restaurantId, page, pageSize);
        return Ok(result);
    }
}