using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using OdeToFoodStepUp.Entities;

namespace OdeToFoodStepUp.DataLayer
{
    public class OdeToFoodDbContext : IdentityDbContext<User>   
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
