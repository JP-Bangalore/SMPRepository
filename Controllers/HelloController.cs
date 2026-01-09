using Microsoft.AspNetCore.Mvc;

namespace SampleGitDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello mmWorld - Git Demo App");
        }

        [HttpGet("time")]
        public IActionResult GetTime()
        {
            return Ok(DateTime.Now);
        }
    }
}
