using System;
using ShoppingList.Views;
using Xamarin.Forms;

namespace ShoppingList
{
    public partial class App : Application
    {
        public EventHandler OnUseCustomTheme;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // apply the color theme
            Device.BeginInvokeOnMainThread(() =>
            {
                UseCustomTheme();
            });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        #region Theme
        public void UseCustomTheme()
        {
            OnUseCustomTheme?.Invoke(Current, null);
        }
        #endregion
    }
}
