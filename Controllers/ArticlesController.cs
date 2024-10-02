using Bloomkergs.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bloomkergs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            var articles = _context.Articles.ToList();
            return Ok(articles); 
        }
    }
}