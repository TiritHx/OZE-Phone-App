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

        private void New_account_button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccountPage());
        }

        private void Login_button_Clicked(object sender, EventArgs e) 
        {
            bool dbquery = true;
            if (!String.IsNullOrEmpty(password.Text) || true && !String.IsNullOrEmpty(username.Text) || true) // true sie usunie ale nie chce mi sie wiecznie wpisywać
            {
                validateLabel.IsVisible = false;
                if (dbquery) // tu ma być sprawdzanie z nazwy i hasła z bazą danych
                {
                    Navigation.PushAsync(new CenterPage(username.Text)); // kiedyś CentralPage
                }
                else
                {
                    validateLabel.Text = "Niepoprawne hasło";
                    validateLabel.IsVisible = true;
                }
            }
            else
            {
                validateLabel.Text = "Dane są niepoprawne";
                validateLabel.IsVisible = true;
            }
        }

        
    }
}
