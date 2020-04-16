using System;
using ShoppingList.Models;
using ShoppingList.Utils;

namespace ShoppingList.ViewModels
{
    public class NewRecipeViewModel : NotifyPropertyChanged
    {
        #region Properties
        public string Title
        {
            get { return "Create a new recipe"; }
        }

        Recipe recipe;
        public Recipe Recipe
        {
            get { return recipe; }
            set
            {
                if (recipe != value)
                {
                    recipe = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
    }
}
