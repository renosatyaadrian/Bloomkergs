using Bloomkergs.Data;
using Bloomkergs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bloomkergs.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ArticlesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Articles
        // [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            // var results = new List<Article>()
            // {
            //     new Article
            //     {
            //         Title = "test1",
            //         Content = "asd",
            //         PublishedDate = new DateTime(2024,2,2)
            //     },
            //     new Article
            //     {
            //         Title = "test2",
            //         Content = "asd",
            //         PublishedDate = new DateTime(2024,2,2)
            //     },
            //     new Article
            //     {
            //         Title = "test3",
            //         Content = "asd",
            //         PublishedDate = new DateTime(2024,2,2)
            //     },
            // };
            var results = await _dbContext.Articles.ToListAsync();
            var realResult = new ArticleViewModel()
            {
                Articles = results
            };

            return RedirectToPage("/Index", new { realResult });;
        }
    }
}