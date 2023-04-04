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
			Create_Item(username, "Turbina nr 1", "1234567890" , 220 , 1790 ); //todo: zrobic loopa for each ale jaka tablicą jeszcze myśle
            Create_Item(username, "Turbina nr 2", "1234567890", 240, 2090);
            Create_Item(username, "Turbina nr 3", "1234567890", 300, 1830);
            Create_Item(username, "Turbina nr 4", "1234567890", 20, 185);
            Create_Item(username, "Turbina nr 5", "1234567890", 0, 90);
            Create_Item(username, "Turbina nr 6", "1234567890", 57, 673);
            Create_Item(username, "Turbina nr 7", "1234567890", 401, 2703);
        }

		public void Create_Item(string id, string name, string password, int last_hour_voltage, int last_day_voltage) 
		{
			//int last_hour_voltage = 220; // tu będzie podłączenie z bazą danych lub pompą żeby dostać informacje o prądzie itd
			//int last_day_voltage = 1790; // te zmienne jeszcze są do zmiany, sa tylko tymczasowe

			StackLayout new_stack = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex("#2196F3"),
				Orientation = StackOrientation.Vertical,
				Margin = new Thickness(20, 15, 20, 15),
				Children =
				{
					new Label
					{
						Text = name,
						TextColor = Color.White,
						HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
						FontSize = 30
					},
					new Frame
					{
                        BackgroundColor = Color.Transparent,
                        CornerRadius = 10,
						Content =
							new StackLayout
							{
								Orientation = StackOrientation.Vertical,
								Margin = new Thickness(0), // do usunięcia lub zmiany idk yet
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
    }
}