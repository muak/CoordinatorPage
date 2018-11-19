using System;
using Xamarin.Forms;
namespace Sample.Renderers
{
    public class NestedListView:ListView
    {
        public NestedListView() : base(ListViewCachingStrategy.RecycleElement)
        {
        }
    }
}
