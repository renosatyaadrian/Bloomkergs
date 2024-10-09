using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client
{
    public class HomeController : Controller
    {
		private readonly HttpClient _httpClient = new HttpClient();

	    public HomeController()
	    {
	   }

        public async Task<IActionResult> Index()
        {
	        var logs = await GetAuthors();


            return View(logs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private async Task<List<AuthorDto>> GetAuthors()
        {
	        var res = await _httpClient.GetAsync("https://localhost:9001/api/values");
	        if (res.IsSuccessStatusCode)
	        {
		        var content = await res.Content.ReadAsStringAsync();
		        var authors = JsonConvert.DeserializeObject<List<AuthorDto>>(content);
		        return authors;
	        }

	        return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });


        public class AuthorDto
        {
            public Guid Id { get; set; }
	        public string FullName { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Bio { get; set; } = string.Empty;
        }
    }
}