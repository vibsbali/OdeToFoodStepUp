using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using OdeToFoodStepUp.Service;

namespace OdeToFoodStepUp.ViewComponents
{
    public class Greeting : ViewComponent
    {
        private readonly IGreeter greeter;

        public Greeting(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = greeter.GetGreeting();
            return View("Default",model);
        }
    }
}
