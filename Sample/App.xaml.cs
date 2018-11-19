using Prism;
using Prism.Ioc;
using Prism.Unity;
using Sample.Views;

namespace Sample
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }


        protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("MyNavigationPage/MainPage");
		}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MyNavigationPage>();
        }
    }
}

