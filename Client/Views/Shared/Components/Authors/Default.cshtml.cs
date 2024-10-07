// CallToActionViewComponent.cs
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Client.HomeController;

public class AuthorsViewComponent : ViewComponent
{
	private readonly HttpClient _httpClient = new HttpClient();
    public async Task<IViewComponentResult> Invoke()
    {
        // Your logic here
        var res = await _httpClient.GetAsync("https://localhost:9001/api/values");
	        if (res.IsSuccessStatusCode)
	        {
		        var content = await res.Content.ReadAsStringAsync();
		        var authors = JsonConvert.DeserializeObject<List<AuthorDto>>(content);
		        // return authors;
	        }

        return View(); // This will render Default.cshtml
    }
}
