using Bloomkergs.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bloomkergs.Controllers
{
    [Route("[controller]")]
    public class AuthorsController : Controller
    {
        private readonly ILogger<AuthorsController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public AuthorsController(ILogger<AuthorsController> logger,
                                 ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var results = await _dbContext.Articles.ToListAsync();
            return View(results);
        }
    }
}