using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFoodStepUp.Entities;
using OdeToFoodStepUp.Service;

namespace OdeToFoodStepUp.DataLayer
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return context.Restaurants;
        }

        public Restaurant Get(int id)
        {
            return context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            context.Add(restaurant);
            context.SaveChanges();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
