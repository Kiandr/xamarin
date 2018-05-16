using System.Reflection;
using Xamarin.Forms;

namespace Enliven.Controllers
{
	class EnlivenMainController
	{
		private Page EnlivenMainPage { get; set; }
	    private Label TapHereLabel { get; set; }
	    private int TapCounter { get; set; }

	    public Page GetEnlivenMainPage()
		{
			return EnlivenMainPage;
			;
		}

	    public EnlivenMainController(Page enlivenMainPage)
	    {
	        EnlivenMainPage = enlivenMainPage;
	    }
        public EnlivenMainController()
        {

            TapCounter = 0;
            var assembly = typeof(EnlivenMainController).GetTypeInfo().Assembly;
		    //   EnlivenMainPage = new ContentPage() { Content = new Label() { Text = "Hello Ke" } };
		    var enlivenLogo = new Image
		    {
		        Source = ImageSource.FromResource("Enliven.Resources.reverse_mark.png", assembly)
		    };
            var layout = new StackLayout();
			var button = new Button
			{
				Text = "StackLayout",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			var upperGreenColor = new BoxView
			{
				Color = Color.FromRgb(61, 70, 67),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			var lowerGreenColor = new BoxView
			{
				Color = Color.FromRgb(61, 70, 67),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 75,
			};


		    TapHereLabel = new Xamarin.Forms.Label()
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


            var tapRecognizer = new TapGestureRecognizer();
		    tapRecognizer.Tapped += TapRecognizer_Tapped;


		    TapHereLabel.GestureRecognizers.Add(tapRecognizer);

			layout.Children.Add(upperGreenColor);
			layout.Children.Add(enlivenLogo);
			layout.Children.Add(TapHereLabel);
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

        /// <summary>
        /// Event lister page tap here 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TapRecognizer_Tapped(object sender, System.EventArgs e)
        {
            TapCounter++;
            TapHereLabel.TextColor = TapCounter%2 == 0 ? Color.Aqua : Color.Chartreuse;
        }
    }
}

