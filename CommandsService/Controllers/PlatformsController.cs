using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
  [Route("api/c/[controller]")]
  [ApiController]
  public class PlatformsController : ControllerBase
  {
    public PlatformsController()
    {

    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
      Console.WriteLine("TestInboundConnection");
      return Ok("Inbound test of from platform controller");
    }

  }
}