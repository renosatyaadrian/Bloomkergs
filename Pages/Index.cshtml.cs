using Bloomkergs.Data;
using Bloomkergs.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

// namespace Bloomkergs.Pages;

public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Article> Articles { get; set; } = new List<Article>();

        public async Task OnGetAsync()
        {
            // Fetch data from the database or simulate the data as needed
            Articles = await _dbContext.Articles.ToListAsync(); // Make sure this fetches your articles
        }
    }