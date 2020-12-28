using EventBusImpl.Events;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace EventBusImpl.Controllers
{
    [ApiController]
    [Route("")]
    public class TestController : ControllerBase
    {
        private readonly IBusClient _bus;
        public TestController(IBusClient bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _bus.PublishAsync<UserCreated>(new UserCreated {Email = "Something@gmail.com", Name = "Something"});
            return Ok();
        }
    }
}
