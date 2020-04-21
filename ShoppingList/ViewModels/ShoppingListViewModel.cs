using System.Collections.ObjectModel;
using System.Windows.Input;
using ShoppingList.Models;
using ShoppingList.Views;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel : BaseViewModel
    {

        public ShoppingListViewModel()
        {
            //@TODO: remove, mock
            Ingredients = new ObservableCollection<Ingredient>();
            Ingredients.Add(new Ingredient { Label = "test avec un nom très très très long long long vraiment vraiment long et même beaucoup trop long", Quantity = 2, Weight = "0g" });
            //@ENDTODO: remove, mock

            OpenPopup = new Command(OpenPopupCommand);
            ClosePopup = new Command(ClosePopupCommand);
            AddIngredient = new Command(AddIngredientCommand);

            MessagingCenter.Subscribe<NewRecipePage, Ingredient>(this, "AddItem", (obj, item) =>
            {
                var newItem = item as Ingredient;
                Ingredients.Add(newItem);
            });
        }

        #region Properties
        ObservableCollection<Ingredient> ingredients;
        public ObservableCollection<Ingredient> Ingredients
        {
            get => ingredients;
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
            PopupVisible = false;
        }
        #endregion
    }
}