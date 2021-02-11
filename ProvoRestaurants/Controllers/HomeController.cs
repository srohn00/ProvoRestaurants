using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoRestaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        [HttpGet()]
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();
            foreach (TopRestaurant r in TopRestaurant.GetRestaurants())
            {
                
#nullable enable
                string? favDish = r.FavoriteDish ?? "They're all tasty!";
                string? phone = r.Phone;
                string? website = r.Website ?? "Coming soon.";
#nullable disable

                //restaurantList.Add(string.Format("#{0}: {1} ({2}) {3} {4} {5}", rank, r.Name, favDish, r.Address, phone, website));
                restaurantList.Add(string.Format("#{0}: {1} Favorite Dish: {2} Address: {3} Phone #: {4} Website: {5}", r.Rank, r.Name, favDish, r.Address, phone, website));
            }
            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult AddRestaurant()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRestaurant(AddRestaurant addRestaurant)
        {
            TempStorage.AddRestaurant(addRestaurant);
            return View("Confirmation", addRestaurant);
        }
        public IActionResult Recommendations()
        {
            return View(TempStorage.Restaurants);
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
