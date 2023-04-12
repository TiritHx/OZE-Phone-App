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
    public partial class DevicePage : ContentPage
    {
        public DevicePage()
        {
            InitializeComponent();
        }

        public DevicePage(string DeviceName, string DeviceId)
        {
            InitializeComponent();
            DeviceNameLabel.Text = "Nazwa: "+ DeviceName;
            DeviceIdLabel.Text = "Id: " + DeviceId;
        }
    }
}