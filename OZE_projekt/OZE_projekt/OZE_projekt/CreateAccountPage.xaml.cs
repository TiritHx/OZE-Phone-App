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
                CreateAccountButton.IsEnabled = true;
                CreateAccountButton.Text = "Utwórz nowe konto";
            }
            else
            {
                CreateAccountButton.IsEnabled = false;
                CreateAccountButton.Text = "Hasła nie są takie same";
            }
        }

        private void CreateAccount_Button_Clicked(object sender, EventArgs e)
        {
            //Trza zrobić walidacje powtórzone hasła, jeśli git to dodaj konto do bazy danych
            if(password.Text == repeat_password.Text)
            {

            }
            else
            {
                
            }
        }
    }
}