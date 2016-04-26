using Microsoft.AspNet.Mvc;
using OdeToFoodStepUp.Models;

namespace OdeToFoodStepUp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new Restaurant
            {
                Id = 1,
                Name = "Sabatino's"
            };

            return new ObjectResult(model);
        }
    }
}
