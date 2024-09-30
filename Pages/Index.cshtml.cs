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

        public void OnGet(List<Article> articles)
        {
            Articles = [.. _dbContext.Articles];
        }
    }