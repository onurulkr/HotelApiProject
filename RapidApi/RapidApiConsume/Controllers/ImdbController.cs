using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient(); 
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tv-shows-database.p.rapidapi.com/?movieid=tt1375666"),
                Headers =
    {
        { "Type", "get-movie-details" },
        { "X-RapidAPI-Key", "13e0f27fefmshcc18f89a7bca370p1a7e8ejsn4b7011472cef" },
        { "X-RapidAPI-Host", "movies-tv-shows-database.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
            }

            return View();
        }
    }
}
