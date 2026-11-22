using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.MenuItemServices;
using AddisEats.Api.Models;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]

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
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = _menuItemService.GetById(id);
        return   Ok(result);
    }
    [HttpPost()]
    public IActionResult CreateMenuItem([FromBody] MenuItem create)
    {
        var menuitem = _menuItemService.CreateMenuItem(create);
        return CreatedAtAction(nameof(GetById), new {id=menuitem.Id} ,menuitem);
    }
}