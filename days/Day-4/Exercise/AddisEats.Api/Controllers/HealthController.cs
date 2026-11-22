using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Services.ClockServices;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    public readonly IClockService _clockService;

	public HealthController(IClockService clockService)
	{
		_clockService = clockService;
	}
	[HttpGet]
    public IActionResult Get()
    {
		var currentTime = _clockService.GetCurrentTime();
		return Ok(currentTime);
    }
}