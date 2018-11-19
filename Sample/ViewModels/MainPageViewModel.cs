using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace Sample.ViewModels
{
    public class MainPageViewModel : BindableBase
	{
        public ObservableCollection<string> ItemsSource { get; } = new ObservableCollection<string>();

        public MainPageViewModel()
		{
            for (var i = 0; i < 100; i++)
            {
                ItemsSource.Add($"Name{i}");
            }
        }

	}
}

