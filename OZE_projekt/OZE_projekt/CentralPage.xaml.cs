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

        public class ReturnedData
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Voltage { get; set; }
        }

        public CentralPage ()
		{
			InitializeComponent ();
		}

        public CentralPage(string username)
        {
            InitializeComponent();
			username_label.Text = "Witaj "+username;
			ReturnedData[] data = new ReturnedData[]
			{
                new ReturnedData {Id = "03248048423987", Name = "Turbina nr 1", Voltage = 220},
				new ReturnedData {Id = "54987593878454", Name = "Turbina nr 2", Voltage = 240},
				new ReturnedData {Id = "92371643984738", Name = "Turbina nr 3", Voltage = 300},
				new ReturnedData {Id = "62230940954594", Name = "Turbina nr 4", Voltage = 20},
				new ReturnedData {Id = "78787858423987", Name = "Turbina nr 5", Voltage = 0},
				new ReturnedData {Id = "02845576873987", Name = "Turbina nr 6", Voltage = 500},
            };

			foreach (var item in data)
			{
				Create_Item(item.Id ,item.Name, item.Voltage);
			}
        }

		public void Create_Item(string id, string name, int voltage) 
		{
            ImageButton button1 = new ImageButton
            {
                HorizontalOptions = LayoutOptions.End, // end - prawa strona, start - lewa strona
                Source = "cog_wheel2.png",
                BackgroundColor = Color.Transparent,
                HeightRequest = 35,
                WidthRequest = 35,
                Margin = new Thickness(5)
            };

            button1.Clicked += (sender, args) =>
            {
				//DisplayAlert("Hello", "Welcome to Xamarin.Forms", "OK");
				Navigation.PushAsync(new DevicePage(name, id)); 
            };

            StackLayout new_stack = new StackLayout
			{
				//HorizontalOptions = LayoutOptions.Center,
				//VerticalOptions = LayoutOptions.Center,
				BackgroundColor = Color.FromHex("#B38FFF"),
				Orientation = StackOrientation.Vertical,
				//Margin = new Thickness(20, 15),
				Children =
				{
					new StackLayout
					{
						Margin = new Thickness(-20, -20, -20, -20), //-20, -20, -20, 0 tak też jest git
						BackgroundColor = Color.FromHsla(0, 100, 100, 0), // 0, 100, 100, 0.2 tak też jest git
						VerticalOptions = LayoutOptions.Start,
						Children =
						{
							button1
								
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
											Text = voltage + "Wh",
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
				BackgroundColor = Color.FromHex("#B38FFF"),
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