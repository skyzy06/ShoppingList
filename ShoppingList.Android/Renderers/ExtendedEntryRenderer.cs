using System;
using Android.Content;
using ShoppingList.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(handler: typeof(Entry), target: typeof(ExtendedEntryRenderer))]
namespace ShoppingList.Droid.Renderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        public ExtendedEntryRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            Control.SetPadding(Control.PaddingLeft, 0, Control.PaddingRight, Control.PaddingBottom);
        }
    }
}
