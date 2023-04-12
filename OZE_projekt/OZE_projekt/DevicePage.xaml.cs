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

        private void Change_device_name_Button_Clicked(object sender, EventArgs e)
        {
            DeviceNewName.Text = DeviceNameLabel.Text.Substring(6, DeviceNameLabel.Text.Length - 2);
            if (DeviceNameLabel.IsVisible)
            {
                DeviceNameLabel.IsVisible = false;
                DeviceNewName.IsVisible = true;
            }
            else
            {
                DeviceNameLabel.IsVisible = true;
                DeviceNewName.IsVisible = false;
            }
        }
    }
}