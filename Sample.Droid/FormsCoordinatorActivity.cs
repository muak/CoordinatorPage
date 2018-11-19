using System;
using System.Reflection;
using Android.OS;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace Sample.Droid
{
    public class FormsCoordinatorActivity:FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var fieldInfo = typeof(FormsAppCompatActivity).GetField("_layout", BindingFlags.Instance | BindingFlags.NonPublic);
            var root = (RelativeLayout)fieldInfo.GetValue(this);

            root.RemoveFromParent();

            var newRoot = (ViewGroup)LayoutInflater.Inflate(Resource.Layout.CoordinatorPageLayout, null, false);

            var container = newRoot.FindViewById<Android.Widget.FrameLayout>(Resource.Id.coordinatorContent);


            using (var param = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent))
            {
                container.AddView(root, 0, param);
            }

            SetContentView(newRoot);
        }
    }
}
