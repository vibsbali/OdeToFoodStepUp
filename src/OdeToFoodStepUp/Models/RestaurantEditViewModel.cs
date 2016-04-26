using System.ComponentModel.DataAnnotations;
using OdeToFoodStepUp.Entities;

namespace OdeToFoodStepUp.Models
{
    public class RestaurantEditViewModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name = "Cuisine Type")]
        public CuisineType Cuisine { get; set; }
    }
}
