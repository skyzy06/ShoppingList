using ShoppingList.Models;

namespace ShoppingList.ViewModels
{
    public class NewRecipeViewModel : BaseViewModel
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
