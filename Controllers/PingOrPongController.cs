using Microsoft.AspNetCore.Mvc;

namespace ping_pong_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PingOrPongController : ControllerBase
{
    private readonly ILogger<PingOrPongController> _logger;

    public PingOrPongController(ILogger<PingOrPongController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{isPingOrPong}")]
    public PingOrPong Get(string isPingOrPong)
    {
        var pingOrPong = new PingOrPong(isPingOrPong);

        return pingOrPong;
    }
}
