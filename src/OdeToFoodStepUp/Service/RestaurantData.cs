using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFoodStepUp.Entities;

namespace OdeToFoodStepUp.Service
{
    class InMemoryRestaurantData : IRestaurantData
    {
        public static IEnumerable<Restaurant> Restaurants { get; set; } = new List<Restaurant>
        {
            new Restaurant { Id = 1, Name = "Tersiguel's"},
            new Restaurant {Id = 2, Name = "LJ's and the Kat"},
            new Restaurant {Id = 3, Name = "King's contrivance"}
        };

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants;
        }

        public Restaurant Get(int id)
        {
            return Restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}