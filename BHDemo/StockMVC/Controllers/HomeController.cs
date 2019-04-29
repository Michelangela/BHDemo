using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using StockMVC.Helper;
using StockMicroservice.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StockMVC.Models;
using System.Diagnostics;

namespace StockMVC.Controllers
{
    public class HomeController : Controller
    {
        StockAPI stockAPI = new StockAPI();

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            List<Stock> stocks = new List<Stock>();
            HttpClient client = stockAPI.Initialize();
            HttpResponseMessage resp = await client.GetAsync("https://localhost:44339/api/stocks");
            if (resp.IsSuccessStatusCode)
            {
                var result = resp.Content.ReadAsStringAsync().Result;
                stocks = JsonConvert.DeserializeObject<List<Stock>>(result);
            }

            return View(stocks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
