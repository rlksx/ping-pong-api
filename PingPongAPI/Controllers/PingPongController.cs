using Microsoft.AspNetCore.Mvc;
using PingPongAPI.Models;

namespace PingPongAPI.Controllers;

[ApiController]
public class PingPongController : ControllerBase
{
    [HttpGet("/api/v1/[controller]/{response}")]
    public IActionResult GetAsync(string response)
    {
        var pingPong = new PingPong();
        
        switch (response.Trim().ToLower())
        {
            case "pong": pingPong.msg = "Ping"; break;
            case "ping": pingPong.msg = "Pong"; break;
            default: return NotFound();
        }
        return Ok(pingPong);
    }
}