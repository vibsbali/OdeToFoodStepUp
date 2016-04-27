using Microsoft.Data.Entity;
using OdeToFoodStepUp.Entities;

namespace OdeToFoodStepUp.DataLayer
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
