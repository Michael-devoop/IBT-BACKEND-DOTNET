using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.OrderServices;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var order = _orderService.GetById(id);
        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }
    [HttpPost()]
    public IActionResult CreateOrder([FromBody] CreateOrderDTO createDTO)
    {
        var order = _orderService.CreateOrder(createDTO);
        return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
    }

}