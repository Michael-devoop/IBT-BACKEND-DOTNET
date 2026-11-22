using AddisEats.Api.Services.ClockServices;

namespace AddisEats.Api.Services.ClockServices;

public class ClockService : IClockService
{
    public DateTime GetCurrentTime()
    {
        return DateTime.Now;
    }
}