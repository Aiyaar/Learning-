using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Learning_.ViewModels
{
    internal class PowerViewModel : BindableObject
    {

        PowerViewModel()
        {
            SettingsCommand = new Command(async () => await App.Current.MainPage.Navigation.PushModalAsync(new SettingsPage()));
            PowerCommand = new Command(async () => await App.Current.MainPage.Navigation.PushModalAsync(new PowerPage()));
            VolumeCommand = new Command(async () => await App.Current.MainPage.Navigation.PushModalAsync(new VolumePage()));
        }

     


            
        public ICommand SelectCommand { get; }
        public ICommand SettingsCommand { get; private set; }
        public ICommand PowerCommand { get; private set; }



        public ICommand VolumeCommand { get; private set; }

    }


}
