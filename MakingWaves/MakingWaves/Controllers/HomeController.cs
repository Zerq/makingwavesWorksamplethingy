using MakingWaves.Helpers;
using MakingWaves.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace MakingWaves.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("{controller=Home}/{action=Index}/{page=1}")]
        public async Task<IActionResult> Index(int page)
        {
            Func<ExampleData, int> getFirstBit = n => int.Parse(n.PantoneValue.Split('-')[0]);

            var exampleData = await ExampleHelper.FetchExample(10, page);

            var group1 = exampleData.Data.Where(n => getFirstBit(n) % 3 == 0)
                .OrderBy(n => n.Year).ToList();

            var group2 = exampleData.Data.Where(n =>
                   getFirstBit(n) % 3 != 0
                    &&
                   getFirstBit(n) % 2 == 0
                 )
                .OrderBy(n => n.Year).ToList();

            var group3 = exampleData.Data.Where(n =>
                getFirstBit(n) % 3 != 0
                &&
               getFirstBit(n) % 2 != 0
                )
                .OrderBy(n => n.Year).ToList();

            (List<ExampleData> Group1, List<ExampleData> Group2, List<ExampleData> Group3, PagingModel paging) result = 
                (
                group1, 
                group2, 
                group3, 
                new PagingModel() { Current = page, PageCount = exampleData.TotalPages }
                );

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
