using sygmaemrek.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace sygmaemrek.ViewModel
{
    public class MainViewModel
    {
        public Command gotoCmd { get; set; }
        public MainViewModel()
        {
            gotoCmd = new Command(gotonearby);
        }

        private void gotonearby(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new NearbyPage());
        }
    }
}
