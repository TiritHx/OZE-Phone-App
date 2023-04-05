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
    public partial class CenterPage : ContentPage
    {
        public CenterPage()
        {
            InitializeComponent();
        }

        public CenterPage(string username)
        {
            InitializeComponent();
            username_label.Text = "Witaj " + username;
        }
        
    }
}