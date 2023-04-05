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
			Create_Item("03248048423987", "Turbina nr 1", "1234567890" , 220 , 1790 ); //todo: zrobic loopa for each ale jaka tablicą jeszcze myśle
            Create_Item("54987593878454", "Turbina nr 2", "1234567890", 240, 2090);
            Create_Item("92371643984738", "Turbina nr 3", "1234567890", 300, 1830);
            Create_Item("62230940954594", "Turbina nr 4", "1234567890", 20, 185);
            Create_Item("79238497493998", "Turbina nr 5", "1234567890", 0, 90);
            Create_Item("68934983477483", "Turbina nr 6", "1234567890", 57, 673);
            Create_Item("24234673247777", "Turbina nr 7", "1234567890", 401, 2703);
        }

		public void Create_Item(string id, string name, string password, int last_hour_voltage, int last_day_voltage) 
		{
			//int last_hour_voltage = 220; // tu będzie podłączenie z bazą danych lub pompą żeby dostać informacje o prądzie itd
			//int last_day_voltage = 1790; // te zmienne jeszcze są do zmiany, sa tylko tymczasowe

			StackLayout new_stack = new StackLayout
			{
				//HorizontalOptions = LayoutOptions.Center,
				//VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex("#2196F3"),
				Orientation = StackOrientation.Vertical,
				//Margin = new Thickness(20, 15),
				Children =
				{
					new StackLayout
					{
						Margin = new Thickness(-20, -20, -20, -20),
						BackgroundColor = Color.FromHsla(0, 100, 100, 0), // 0, 100, 100, 0.2 tak też jest git
						VerticalOptions = LayoutOptions.Start,
						Children =
						{
							new ImageButton
							{
								HorizontalOptions= LayoutOptions.End, // end - prawa strona, start - lewa strona
								Source = "cog_wheel2.png",
                                BackgroundColor = Color.Transparent,
								HeightRequest = 35,
								WidthRequest = 35,
								Margin = new Thickness(5)
								//Clicked = {} clicked nie istnieje        NIE ISTNIEJE
								// trzeba robić jakąś wy.....wistą funkcje => https://learn.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/imagebutton
								// może gesturerecognizers zadziała, dowiem sie w swoim czasie ¯\_(ツ)_/¯
                            }
                        }
                    },
                    new Label
					{
						Text = name,
						TextColor = Color.White,
						HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
						FontSize = 30
					},
					new Label
					{
						Text = "ID: "+id,
                        TextColor = Color.White,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        FontSize = 15
                    }
					,
					new Frame
					{
                        BackgroundColor = Color.FromHsla(0, 100, 100, 0.7),
						//Margin = new Thickness(-50, 0), // -100 , 0 jest ciekawe
                        CornerRadius = 10,
						Content =
							new StackLayout
							{
								Orientation = StackOrientation.Vertical,
								//Padding = new Thickness(-40, 0), // this padding funny tho
								BackgroundColor = Color.Transparent,
                                Children =
								{
									new Frame
									{
										Content = new Label
										{
											Text = "1h: " + last_hour_voltage + "V",
											FontSize = 20,
											VerticalTextAlignment = TextAlignment.Center,
											HorizontalTextAlignment = TextAlignment.Center,
											Margin = new Thickness(0) //trzeba poprawić marginesy
										},
                                        CornerRadius = 10,
                                        BackgroundColor = Color.White,
                                        Margin = new Thickness(5)
                                    },
									new Frame
									{
										Content = new Label
										{
											Text = "24h: " + last_day_voltage + "V",
											FontSize = 20,
											VerticalTextAlignment = TextAlignment.Center,
											HorizontalTextAlignment = TextAlignment.Center,
                                            Margin = new Thickness(0) //trzeba poprawić marginesy
                                        },
										CornerRadius = 10,
										BackgroundColor = Color.White,
                                        Margin = new Thickness(5)
                                    }
								}
							}
					}
				}
			};
			Frame new_frame = new Frame 
			{
				BackgroundColor = Color.FromHex("#2196F3"),
                Margin = new Thickness(20, 20, 20, 0),
                CornerRadius = 10,
				Content = new_stack
			};
			main_stack.Children.Add(new_frame);
        }

        private void Edit_button_Clicked(object sender, EventArgs e)
        {

        }
    }
}