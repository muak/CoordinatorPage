using System;
using Xamarin.Forms;

namespace Sample.Renderers
{
    public class CoordinatorPage:NavigationPage
    {
        public static readonly BindableProperty IsBarScrollProperty =
            BindableProperty.CreateAttached(
                    "IsBarScroll",
                    typeof(bool),
                    typeof(CoordinatorPage),
                    default(bool)
                );

        public static void SetIsBarScroll(BindableObject view, bool value)
        {
            view.SetValue(IsBarScrollProperty, value);
        }

        public static bool GetIsBarScroll(BindableObject view)
        {
            return (bool)view.GetValue(IsBarScrollProperty);
        }

    }
}
