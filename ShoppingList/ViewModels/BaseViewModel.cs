using ShoppingList.Utils;
using ShoppingList.Views;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class BaseViewModel : NotifyPropertyChanged
    {
        // Reference to the MasterDetailPage to change the current page
        protected MainPage RootPage { get => Application.Current.MainPage as MainPage; }
    }
}
