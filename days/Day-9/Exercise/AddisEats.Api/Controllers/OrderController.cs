using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.OrderServices;
using AddisEats.Api.DTOs;
using AddisEats.Api.Common;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/orders")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("{id:int}")]
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
        if (!order.IsSuccess)
        {
            return Problem(
                title: order.Error?.Message,
                statusCode: order.Error?.Status,
                detail: order.Error?.Code
                );
        }
        var result =order.Value;
  
        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result);
    }

}