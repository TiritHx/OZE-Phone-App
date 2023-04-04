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
	public partial class CentralPage : ContentPage
	{
		public CentralPage ()
		{
			InitializeComponent ();
		}

        public CentralPage(string username)
        {
            InitializeComponent();
			username_label.Text = "Witaj "+username;
        }

		public void Create_Item(string id, string password) 
		{
		
		}
    }
}