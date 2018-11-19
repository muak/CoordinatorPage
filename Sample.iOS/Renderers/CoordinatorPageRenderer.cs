using System;
using Sample.iOS.Renderers;
using Sample.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CoordinatorPage), typeof(CoordinatorPageRenderer))]
namespace Sample.iOS.Renderers
{
    public class CoordinatorPageRenderer:NavigationRenderer
    {
        CoordinatorPage _coordinatorPage => Element as CoordinatorPage;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                _coordinatorPage.Popped -= OnPopped;
            }

            if (e.NewElement != null)
            {
                _coordinatorPage.Popped += OnPopped;
                UpdateIsBarScroll();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _coordinatorPage.Popped -= OnPopped;
            }
            base.Dispose(disposing);
        }

        void OnPopped(object sender, NavigationEventArgs e)
        {
            UpdateIsBarScroll();
        }

        public override void PushViewController(UIViewController viewController, bool animated)
        {
            base.PushViewController(viewController, animated);

            UpdateIsBarScroll();
        }

        void UpdateIsBarScroll()
        {
            HidesBarsOnSwipe = CoordinatorPage.GetIsBarScroll(_coordinatorPage.CurrentPage);
        }
    }
}
