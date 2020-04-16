using System.Collections.Generic;

namespace ShoppingList.Models
{
    public class Recipe
    {
        public string Label { get; set; }

        public string description { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
