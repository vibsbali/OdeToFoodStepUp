using Microsoft.AspNet.Mvc;
using OdeToFoodStepUp.Entities;
using OdeToFoodStepUp.Service;

namespace OdeToFoodStepUp.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = restaurantData.GetAll();

            return View(model);
        }
    }
}
