using Bloomkergs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bloomkergs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var results = await _dbContext.Authors.ToListAsync();
            return View(results);
        }
    }
}