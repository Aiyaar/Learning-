using Learning_.ViewModels;

namespace Learning_;

public partial class PowerPage : ContentPage
{
	public PowerPage()
	{
		InitializeComponent();
		BindingContext = new PowerViewModel();
	}
}