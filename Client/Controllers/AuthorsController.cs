using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    [Route("[controller]")]
    public class AuthorsController : Controller
    {
        private readonly ILogger<AuthorsController> _logger;
		private readonly HttpClient _httpClient = new HttpClient();

        public AuthorsController(ILogger<AuthorsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}