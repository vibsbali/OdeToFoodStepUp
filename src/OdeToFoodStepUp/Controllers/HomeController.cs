using Microsoft.AspNet.Mvc;
using OdeToFoodStepUp.Entities;
using OdeToFoodStepUp.Models;
using OdeToFoodStepUp.Service;

namespace OdeToFoodStepUp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData restaurantData;
        private readonly IGreeter greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            this.restaurantData = restaurantData;
            this.greeter = greeter;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                Restaurants = restaurantData.GetAll(),
                CurrentGreeting = greeter.GetGreeting()
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = new Restaurant
                {
                    Name = model.Name,
                    Cuisine = model.Cuisine
                };
                restaurantData.Add(restaurant);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
