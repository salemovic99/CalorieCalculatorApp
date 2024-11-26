using CalorieCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalorieCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new CalorieCalculator.Models.CalorieCalculator());
        }

        [HttpPost]
        public IActionResult Index(CalorieCalculator.Models.CalorieCalculator model)
        {
            if (ModelState.IsValid)
            {
                model.Calories = CalculateDailyCalorieRequirement(
                    model.Age, model.Gender, model.Weight, model.Height, model.ActivityLevel);
            }
            return View(model);
        }


        private double CalculateDailyCalorieRequirement(int age, string gender, double weight, double height, double activityLevel)
        {
            double bmr;
            if (gender == "male")
            {
                bmr = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
            }
            else
            {
                bmr = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
            }
            return bmr * activityLevel;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}