using Microsoft.AspNetCore.Mvc;

namespace Bloomkergs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTest()
        {
            return Ok("Test API is working");
        }
    }
}
