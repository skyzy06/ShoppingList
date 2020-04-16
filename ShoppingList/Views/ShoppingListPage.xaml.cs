using System;
using System.ComponentModel;
using ShoppingList.ViewModels;
using Xamarin.Forms;

namespace ShoppingList.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ShoppingListPage : ContentPage
    {
        ShoppingListViewModel viewModel;

        public ShoppingListPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ShoppingListViewModel();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewRecipePage()));
        }
    }
}