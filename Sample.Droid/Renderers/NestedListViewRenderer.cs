using System;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Xamarin.Forms;
using Android.Support.V4.View;
using Sample.Renderers;
using Sample.Droid.Renderers;

[assembly: ExportRenderer(typeof(NestedListView), typeof(NestedListViewRenderer))]
namespace Sample.Droid.Renderers
{
    public class NestedListViewRenderer:ListViewRenderer
    {
        public NestedListViewRenderer(Context context):base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement != null)
            {
                ViewCompat.SetNestedScrollingEnabled(Control, true);
            }
        }
    }
}
