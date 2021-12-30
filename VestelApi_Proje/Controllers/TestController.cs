using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VestelApi_Proje.Controllers
{
    public class TestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("http://localhost:19181/Api/Default");
            var JsonString = await responseMessage.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<Category>>(JsonString);
            return View(categories);
        }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
