using System.Collections.ObjectModel;
using System.Windows.Input;
using ShoppingList.Models;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel : BaseViewModel
    {

        public ShoppingListViewModel()
        {
            OpenPopup = new Command(OpenPopupCommand);
            ClosePopup = new Command(ClosePopupCommand);
            AddIngredient = new Command(AddIngredientCommand);
            IsIngredientsEmpty = true;

            //MessagingCenter.Subscribe<NewRecipePage, Ingredient>(this, "AddItem", (obj, item) =>
            //{
            //    var newItem = item as Ingredient;
            //    Ingredients.Add(newItem);
            //});
        }

        #region Properties
        ObservableCollection<Ingredient> ingredients;
        public ObservableCollection<Ingredient> Ingredients
        {
            get
            {
                if(ingredients == null)
                {
                    ingredients = new ObservableCollection<Ingredient>();
                }
                return ingredients;
            }
            set
            {
                ingredients = value;
                OnPropertyChanged();
            }
        }

        bool popupVisible;
        public bool PopupVisible
        {
            get => popupVisible;
            set
            {
                popupVisible = value;
                OnPropertyChanged();
            }
        }

        string newIngredientName;
        public string NewIngredientName
        {
            get => newIngredientName;
            set
            {
                newIngredientName = value;
                OnPropertyChanged();
            }
        }

        bool isIngredientsEmpty;
        public bool IsIngredientsEmpty
        {
            get => isIngredientsEmpty;
            set
            {
                isIngredientsEmpty = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands
        public ICommand OpenPopup { get; private set; }
        void OpenPopupCommand()
        {
            NewIngredientName = "";
            PopupVisible = true;
        }

        public ICommand ClosePopup { get; private set; }
        void ClosePopupCommand()
        {
            PopupVisible = false;
        }

        public ICommand AddIngredient { get; private set; }
        void AddIngredientCommand()
        {
            if (NewIngredientName != null && NewIngredientName.Length > 0)
            {
                Ingredients.Add(new Ingredient
                {
                    Label = NewIngredientName,
                    Quantity = 1,
                    Weight = "0g"
                });
            }
            IsIngredientsEmpty = false;
            PopupVisible = false;
        }
        #endregion
    }
}