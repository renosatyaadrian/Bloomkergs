using Client.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

// namespace Bloomkergs.Pages;

public class IndexModel : PageModel
{
    private readonly HttpClient _httpClient;

    // public List<Article> Articles { get; set; }

    public IndexModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task OnGetAsync()
    {
        // var response = await _httpClient.GetAsync("http://localhost:5000/api/Articles");
        
        // if (response.IsSuccessStatusCode)
        // {
        //     var articlesJson = await response.Content.ReadAsStringAsync();
        //     Articles = JsonConvert.DeserializeObject<List<Article>>(articlesJson);
        // }
        // else
        // {
        //     Articles = new List<Article>(); 
        // }
    }
}