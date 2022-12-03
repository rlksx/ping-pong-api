using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using ping_pong_api.Models;

namespace ping_pong_api.Controllers;

[ApiController]
public class PingPongController : ControllerBase
{
    [HttpGet("/api/v1/[controller]/{response}")]
    public IActionResult GetAsync(string response)
    {
        var pingPong = new PingPong();
        
        switch (response.Trim().ToLower())
        {
            case "pong": pingPong.PingOrPong = "Ping"; break;
            case "ping": pingPong.PingOrPong = "Pong"; break;
            default: return NotFound();
        }
        return Ok(pingPong);
    }
}