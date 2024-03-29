using DotNetMauiApp.ViewModels;

namespace DotNetMauiApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}