using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingList.DataTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuCell : ViewCell
    {
        public MenuCell()
        {
            InitializeComponent();
        }
    }
}
