using Bloomkergs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bloomkergs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ArticlesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var results = await _dbContext.Articles.ToListAsync();
            return View(results);
        }
    }
}