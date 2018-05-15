using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Reflection.Emit;

namespace Enliven.Controllers
{
	class EnlivenMainController
	{
		private Page EnlivenMainPage { get; set; }

		public Page GetEnlivenMainPage()
		{
			return EnlivenMainPage;
			;
		}

		public EnlivenMainController()
		{

			//   EnlivenMainPage = new ContentPage() { Content = new Label() { Text = "Hello Ke" } };
			var enlivenLogo = new Image
			{
				Source = ImageSource.FromResource("Enliven.Resources.reverse_mark.png")
			};

			var layout = new StackLayout();
			var button = new Button
			{
				Text = "StackLayout",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			var UpperGreenColour = new BoxView
			{
				Color = Color.FromRgb(61, 70, 67),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			var LowerGreenColour = new BoxView
			{
				Color = Color.FromRgb(61, 70, 67),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 75,
			};


			var label = new Xamarin.Forms.Label()
			{
				Text = "Tap here to start",

				TextColor = Color.FromHex("#ffffff"),
				FontSize = 20,
				BackgroundColor = Color.FromHex("#3d4643"),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 75,
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalTextAlignment = TextAlignment.Center

			};


			//layout.Children.Add(label);

			layout.Children.Add(UpperGreenColour);
			layout.Children.Add(enlivenLogo);
			layout.Children.Add(label);
			layout.Spacing = 0.01;


			//EnlivenMainPage = new ContentPage()
			//{
			//	//Content = new DatePicker
			//	//{
			//	//	MinimumDate = new DateTime(2018, 1, 1),
			//	//	MaximumDate = new DateTime(2018, 12, 31),
			//	//	Date = new DateTime(2018, 6, 21)
			//	//},
			//	//BackgroundColor = Color.GreenYellow
			//	Content = new Image { Source = ImageSource.FromResource("Enliven.Resources.reverse_mark.png") }
			//};
			EnlivenMainPage = new ContentPage() { Content = layout };
		}
	}
}

