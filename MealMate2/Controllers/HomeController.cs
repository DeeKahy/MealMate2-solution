using MealMate2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MealMate2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // This could be your database context or repository
        // where you fetch your data from.
        // I'm just creating a new list for simplicity here.
        public IActionResult Index()
        {
            string jsonFilePath = "C:/Users/Lenna/Desktop/Projects/MealMate2-solution/MealMate2/Data/USERS/" + User.Identity?.Name + "/Inventory/activeInventory.json";
            return View(ActiveItemModel.LoadItemsFromJson(jsonFilePath));
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Inventory()
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