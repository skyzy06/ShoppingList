using System.Collections.ObjectModel;

using Xamarin.Forms;

using ShoppingList.Models;
using ShoppingList.Views;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel
    {
        public string Title { get; }
        public ObservableCollection<Ingredient> Items { get; set; }

        public ShoppingListViewModel()
        {
            Title = "Shopping List";
            Items = new ObservableCollection<Ingredient>();

            MessagingCenter.Subscribe<NewRecipePage, Ingredient>(this, "AddItem", (obj, item) =>
            {
                var newItem = item as Ingredient;
                Items.Add(newItem);
            });
        }
    }
}