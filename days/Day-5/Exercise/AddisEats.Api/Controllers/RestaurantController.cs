using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.DTOs;
using AddisEats.Api.Mapper;


namespace AddisEats.Api.controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;
    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }
    [HttpGet]
    public IActionResult GetAll([FromQuery] string? address ,[FromQuery]int page,[FromQuery]int pageSize)
    {
        var restaurants = _restaurantService.GetAllRestaurants(address, page, pageSize);
        var restaurantDTOs = restaurants.Select(r => r.ToDTO()).ToList();
        return Ok(restaurantDTOs);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var restaurant = _restaurantService.GetById(id);
        if (restaurant == null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }
    
}