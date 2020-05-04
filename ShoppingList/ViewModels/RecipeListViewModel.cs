using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class RecipeListViewModel : BaseViewModel
    {
        public RecipeListViewModel()
        {
            Recipes = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
            OpenRecipe = new Command(OpenRecipeCommand);
        }

        #region Properties
        ObservableCollection<string> recipes;
        public ObservableCollection<string> Recipes
        {
            get => recipes;
            set
            {
                recipes = value;
                OnPropertyChanged();
            }
        }

        string selectedRecipe;
        public string SelectedRecipe
        {
            get => selectedRecipe;
            set
            {
                if (selectedRecipe != value)
                {
                    selectedRecipe = value;
                    OnPropertyChanged();
                    if (selectedRecipe != null)
                    {
                        OpenRecipe.Execute(null);
                    }
                }
            }
        }
        #endregion

        #region Commands
        public ICommand OpenRecipe { get; private set; }
        async void OpenRecipeCommand()
        {
            await RootPage.Detail.DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            SelectedRecipe = null;
        }
        #endregion
    }
}
