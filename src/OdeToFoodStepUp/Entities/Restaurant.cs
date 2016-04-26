﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFoodStepUp.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Display(Name = "Cuisine Type")]
        public CuisineType Cuisine { get; set; }
    }
}
