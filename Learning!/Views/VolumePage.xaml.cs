using Learning_.ViewModels;

namespace Learning_;

public partial class VolumePage : ContentPage
{
	public VolumePage()
	{
		InitializeComponent();
		BindingContext = new VolumeViewModel();
	}
}