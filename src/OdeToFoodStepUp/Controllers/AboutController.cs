using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Infrastructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OdeToFoodStepUp.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "+1 555-555-5555";
        }

        [Route("country")]
        public string Country()
        {
            return "USA";
        }
    }
}
