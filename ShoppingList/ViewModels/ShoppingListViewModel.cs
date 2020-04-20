using System.Collections.ObjectModel;

using Xamarin.Forms;

using ShoppingList.Models;
using ShoppingList.Views;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel
    {
        public ObservableCollection<Ingredient> Items { get; set; }

        public ShoppingListViewModel()
        {
            Items = new ObservableCollection<Ingredient>();

            Items.Add(new Ingredient { Label = "test avec un nom très très très long long long vraiment vraiment long et même beaucoup trop long", Quantity = 2, Weight = "0g" });

            MessagingCenter.Subscribe<NewRecipePage, Ingredient>(this, "AddItem", (obj, item) =>
            {
                var newItem = item as Ingredient;
                Items.Add(newItem);
            });
        }
    }
}