using Bloomkergs.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bloomkergs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // [ApiExplorerSettings(GroupName = "v1")] // Optional: Specify group name
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
            return Ok(articles); // Mengirim data artikel dalam format JSON
        }
    }
}