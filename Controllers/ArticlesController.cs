using Bloomkergs.Data;
using Bloomkergs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bloomkergs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : Controller // Ensure it inherits from Controller
    {
        private readonly ApplicationDbContext _dbContext;

        // Constructor to inject ApplicationDbContext
        public ArticlesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/Patients
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // var result = await _dbContext.Articles.ToListAsync();
            var results = new List<Article>()
            {
                new Article
                {
                    AuthorId = new Guid(),
                    Content = "asfnklkasnf",
                    PublishedDate = new DateTime(),
                    Id = new Guid(),
                    CreatedDate = new DateTime(),
                    Title = "welknalkwn"
                }
            };
            return View(results);
        }
    }
}