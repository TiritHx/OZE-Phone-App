using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OZE_projekt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void Validate(object sender, EventArgs e)
        {
            if (password.Text == repeat_password.Text)
            {
                create_account_button.IsEnabled = true;
                validateLabel.Text = "Hasła nie są takie same";
                validateLabel.IsVisible = false;
            }
            else
            {
                create_account_button.IsEnabled = false;
                validateLabel.Text = "Hasła nie są takie same";
                validateLabel.IsVisible = true;
            }
        }

        private void Create_account_button_Clicked(object sender, EventArgs e)
        {
            //Trza zrobić walidacje powtórzone hasła, jeśli git to dodaj konto do bazy danych
            if(!String.IsNullOrEmpty(password.Text) && !String.IsNullOrEmpty(repeat_password.Text) && !String.IsNullOrEmpty(username.Text))
            {
                validateLabel.IsVisible = false;
                Navigation.PushAsync(new CenterPage(username.Text)); // kiedyś CentralPage
            }
            else
            {
                validateLabel.Text = "Dane są niepoprawne";
                validateLabel.IsVisible = true;
            }
        }
    }
}