using MauiApp1.ViewModels;

namespace Learning_;

public partial class SourcePage : ContentPage
{
	public SourcePage()
	{
		InitializeComponent();
		BindingContext = new SourcesViewModel();
	}
}