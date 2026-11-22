using AddisEats.Api.Models;
using AddisEats.Api.DTOs;
using AddisEats.Api.Services.UserServices;
using Microsoft.AspNetCore.Mvc;


namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/V1/[controller]")]
public class UserController : ControllerBase
{
    public readonly IUserService _userService;

    //create a constructer 

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet()]
    public IActionResult GetALlUser()
    {
        var result = _userService.GetAllUsers();
        return Ok(result);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = _userService.GetById(id);
        if (result == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(result);
        }

    }
}