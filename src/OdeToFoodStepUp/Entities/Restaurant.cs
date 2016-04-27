using System.ComponentModel.DataAnnotations;

namespace OdeToFoodStepUp.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        [Display(Name = "Cuisine Type")]
        public CuisineType Cuisine { get; set; }

       
    }
}
