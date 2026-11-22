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
    public IActionResult GetAll([FromQuery] RestaurantQuery query)
    {
        var restaurants = _restaurantService.GetAllRestaurants(query);
        return Ok(restaurants);
        

  
    }

    [HttpGet("{restaurantId:int}")]
    public IActionResult GetById(int id)
    {
        var restaurant = _restaurantService.GetById(id);

        if (restaurant == null)
        {
            return NotFound();
        }

        var restaurantDTO = restaurant.ToDTO();

        return Ok(restaurantDTO);
    }
    [HttpGet("active")]
    public IActionResult GetAllActiveResult()
    {
        var restaurants = _restaurantService.GetAllActive();
        var RestaurantDTOs = restaurants.Select(r => r.ToDTO()).ToList();
        return Ok(RestaurantDTOs);
    }
}