using AddisEats.Api.Models;
using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.DTOs;


namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]

public class RestaurantController : ControllerBase

{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpPost()]
    public IActionResult CreateRestaurant([FromBody] RestaurantDTO createDTO)
    {
        var result = _restaurantService.CreateRestaurant(createDTO);
        return CreatedAtAction(result);
    }
}


        //private readonly IRestaurantService _restaurantService;

        //public RestaurantController(IRestaurantService restaurantService)
        //{
        //    _restaurantService = restaurantService;
        //}

        //[HttpGet()]
        //public IActionResult GetAll()
        //{
        //    var result = _restaurantService.GetAll();
        //    return Ok(result);
        //}
        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _restaurantService.GetById(id);
        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(result);
        //}
        //[HttpPost()]
        //public IActionResult CreateRestaurant(Restaurant restaurant)
        //{
        //    var result = _restaurantService.Create(restaurant);
        //    return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        //}