using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OZE_projekt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#B38FFF"), // set the background color of the navigation bar
                BarTextColor = Color.White // set the text color of the navigation bar
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
