using System.Reflection;
using Foundation;
using Syncfusion.SfNumericUpDown.XForms.iOS;
using UIKit;
using Xamarin.Forms;

namespace ShoppingList.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            SfNumericUpDownRenderer.Init();

            App shoppingApp = new App();

            shoppingApp.OnUseCustomTheme += (s, a) =>
            {
                UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

                var prop = typeof(Color).GetRuntimeProperty(nameof(Color.Accent));
                var setter = prop?.SetMethod;
                // Invoke the setter method of the Color.Accent property to overwrite it with the custom accent color
                setter?.Invoke(Color.Accent, new object[] { (Color)Xamarin.Forms.Application.Current.Resources["appAccentColor"] });
            };

            LoadApplication(shoppingApp);

            return base.FinishedLaunching(app, options);
        }
    }
}
