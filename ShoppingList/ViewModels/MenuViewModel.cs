using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using ShoppingList.Models;
using ShoppingList.Resources;
using ShoppingList.Views;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel()
        {
            MenuItemList = new ObservableCollection<HomeMenuItem>
            {
                new HomeMenuItem{
                    Id = 0,
                    Title = AppResources.ShoppingListTitle,
                    IconSource = "shopping_basket.png",
                    TargetType = typeof(ShoppingListPage)
                },
                new HomeMenuItem{
                    Id = 1,
                    Title = AppResources.NewRecipeTitle,
                    IconSource = "shopping_basket.png",
                    TargetType = typeof(NewRecipePage)
                }
            };
        }

        #region Properties
        // menu list
        ObservableCollection<HomeMenuItem> menuItemList = new ObservableCollection<HomeMenuItem>();
        public ObservableCollection<HomeMenuItem> MenuItemList
        {
            get { return menuItemList; }
            set
            {
                menuItemList = value;
                OnPropertyChanged();
            }
        }

        // active page
        HomeMenuItem selectedMenuItem;
        public HomeMenuItem SelectedMenuItem
        {
            get { return selectedMenuItem; }
            set
            {
                if (selectedMenuItem != value)
                {
                    selectedMenuItem = value;
                    if (selectedMenuItem != null)
                    {
                        OpenMenuPage();
                    }
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Methods
        void OpenMenuPage()
        {
            try
            {
                RootPage.Detail = new NavigationPage((Page)Activator.CreateInstance(SelectedMenuItem.TargetType));
                SelectedMenuItem = null;
                RootPage.IsPresented = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
        #endregion
    }
}
