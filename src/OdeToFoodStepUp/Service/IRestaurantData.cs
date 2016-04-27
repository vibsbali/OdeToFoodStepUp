using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFoodStepUp.Entities;

namespace OdeToFoodStepUp.Service
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void Commit();
    }

   
}
