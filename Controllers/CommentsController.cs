using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bloomkergs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : Controller
    {
        private readonly ILogger<CommentsController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public CommentsController(ILogger<CommentsController> logger,
                                  ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        // GET: api/Comments
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var results = await _dbContext.Comments.ToListAsync();
            return View(results);
        }
    }
}