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
    [Obsolete]
    public partial class CenterPage : MasterDetailPage    // Ja już nie chce porzucam elo  benc
    {
        public class Menu //https://luisdavidxamshap.wordpress.com/2018/02/07/hamburger-menu-in-xamarin-forms-step-by-step/
        {
            public string MenuTitle
            {
                get; set;
            }

            public string MenuDetail
            {
                get; set;
            }

            public string MenuIcon
            {
                get; set;
            }
            public Page MenuPage
            {
                get; set;
            }
        }

        //public void MyMenu()
        //{
        //    Detail = new NavigationPage(new MenuPage());
        //    List<Menu> menu = new List<Menu>
        //    {
        //        new Menu{ MenuPage = new MenuPage(), MenuTitle = "test1", MenuDetail = "teścior 1", MenuIcon = "cog_wheel.png"},
        //        new Menu{ MenuPage = new MenuPage(), MenuTitle = "test1", MenuDetail = "teścior 1", MenuIcon = "cog_wheel.png"},
        //        new Menu{ MenuPage = new MenuPage(), MenuTitle = "test1", MenuDetail = "teścior 1", MenuIcon = "cog_wheel.png"},
        //        new Menu{ MenuPage = new MenuPage(), MenuTitle = "test1", MenuDetail = "teścior 1", MenuIcon = "cog_wheel.png"},
        //        new Menu{ MenuPage = new MenuPage(), MenuTitle = "test1", MenuDetail = "teścior 1", MenuIcon = "cog_wheel.png"}
        //    };
        //    MenuList.ItemsSource = menu;
        //}


        public CenterPage()
        {
            InitializeComponent();
        }

        public CenterPage(string username)
        {
            InitializeComponent();
            //username_label.Text = "Witaj " + username;
        }
        
    }
}