using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Tracker.Models
{
    public class RecipeIngredient//TODO
    {
        [Key]
        public int MacroID { get; set; }

        
       

        [Required]
        public int RecipeID { get; set; } // Foreign Key referencing RecipeID

        
        [Required]
        public int IngredientID { get; set; } // Foreign Key referencing IngredientID

        [ForeignKey("RecipeID")]
        public Recipe Recipe { get; set; }
        
        [ForeignKey("IngredientID")]
        public Ingredient Ingredient { get; set; }

    }
}
