using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OZE_projekt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NewAccount_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccountPage());
        }

        
    }
}
