using System.Collections.Generic;
using OdeToFoodStepUp.Entities;

namespace OdeToFoodStepUp.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
