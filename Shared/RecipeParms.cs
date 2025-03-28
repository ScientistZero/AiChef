using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiChef.Shared
{
    public class RecipeParms
    {
        public string? MealTime { get; set; } = "Breakfast"; // Breakfast, Lunch, Dinner, Dessert
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>(); // List of ingredients to include
        public string? SelectedIdea { get; set; }

    }
}
