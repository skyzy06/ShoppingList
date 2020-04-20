using System;
using System.ComponentModel;
using Xamarin.Forms;

using ShoppingList.Models;

namespace ShoppingList.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewRecipePage : ContentPage
    {
        public Ingredient Ingredient { get; set; }

        public NewRecipePage()
        {
            InitializeComponent();

            Ingredient = new Ingredient
            {
                Label = "Item name",
                Quantity = 1,
                Weight = "100g"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Ingredient);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}