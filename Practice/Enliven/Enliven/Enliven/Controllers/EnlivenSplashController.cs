using System;
using System.Reflection;
using Enliven.Constants;
using Enliven.Helpers;
using Enliven.temp;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;

namespace Enliven.Controllers
{
    internal class EnlivenSplashController: EnlivenBaseController
    {
        private static Page EnlivenLoginPage { get; set; }
        private Page EnlivenSplashPage { get; set; }
        private Label TapHereLabel { get; set; }
        private int TapCounter { get; set; }
        public EnlivenSplashController() : base()
        {
            Init();
        }

        public Page GetEnlivenSplashController()
        {
            return this.EnlivenSplashPage;
        }

        private void Init()
        {
            InitEnlivenLoginPage();
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
            //	//	MinimumDate =  new DateTime(2018, 1, 1),
            //	//	MaximumDate = new DateTime(2018, 12, 31),
            //	//	Date = new DateTime(2018, 6, 21)
            //	//},
            //	//BackgroundColor = Color.GreenYellow
            //	Content = new Image { Source = ImageSource.FromResource("Enliven.Resources.reverse_mark.png") }
            //};
            EnlivenSplashPage = new ContentPage() { Content = layout };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TapRecognizer_Tapped(object sender, System.EventArgs e)
        {
            TapCounter++;
            TapHereLabel.TextColor = TapCounter % 2 == 0 ? Color.Aqua : Color.Chartreuse;
            CurrentView = "Splash Page";
            TapHereLabel.Text = CurrentView;
            SwitchPageAsync();



        }

        private void InitEnlivenLoginPage()
        {
            var assembly = typeof(EnlivenMainController).GetTypeInfo().Assembly;
            var enlivenLogo = new Image
            {
                 Source = ImageSource.FromResource("Enliven.Resources.reverse_mark.png", assembly)
            };
            var layout = new StackLayout()
            {
                BackgroundColor = Color.FromRgb(61,70,67),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = 0,
                IsClippedToBounds = true,
                Orientation = StackOrientation.Vertical
            };

            var buttonLogin = new Button
            {
                Text = "Login",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromRgb(61, 70, 67),
                TextColor = Color.White,
                BorderColor = Color.White,
                BorderWidth = 0,
                Margin = 0,
                CornerRadius = 3,

            };

            var button = new Button
            {
                Text = "Back",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromRgb(61, 70, 67),
                TextColor =  Color.White,
                BorderColor = Color.White,
                BorderWidth = 0,
                Margin = 0,
                CornerRadius = 3,
                
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
            var userNameEntry = new Entry() {
                Text = "Enliven User Name",
                HorizontalTextAlignment = TextAlignment.Center ,
                HorizontalOptions = LayoutOptions.FillAndExpand,
               // VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromRgb(61, 70, 67),
                DisableLayout = true,
                TextColor = Color.White,
                
                

            };
            var userPassEntry = new Entry()
            {
                Text = "Enter Password",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                // VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromRgb(61, 70, 67),
                DisableLayout = true,
                TextColor = Color.White,



            };

            TapHereLabel = new Xamarin.Forms.Label()
            {
                Text = "Login Page",

                TextColor = Color.FromHex("#ffffff"),
                FontSize = 20,
                BackgroundColor = Color.FromHex("#3d4643"),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center

            };


            var layoutButtons = new StackLayout()
            {
                BackgroundColor = Color.FromRgb(61, 70, 67),

                Margin = 0,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Horizontal

            };

            layoutButtons.Children.Add(button);
            layoutButtons.Children.Add(buttonLogin);

            //var tapRecognizer = new TapGestureRecognizer();
            //tapRecognizer.Tapped += TapRecognizer_Tapped;
            button.Clicked += Button_Clicked;
            buttonLogin.Clicked += ButtonLogin_ClickedAsync;

            // button.GestureRecognizers.Add(tapRecognizer);

            layout.Children.Add(enlivenLogo);
            layout.Children.Add(upperGreenColor);
            layout.Children.Add(userNameEntry);
            layout.Children.Add(userPassEntry);
            layout.Children.Add(layoutButtons);

           // layout.Children.Add(lowerGreenColor);
           layout.Spacing = 0.0;

            EnlivenLoginPage = new ContentPage()
            {
                BackgroundColor =  Color.FromRgb(61,70,67),
                Content = layout
            };
        }



        async void Button_Clicked(object sender, EventArgs e)
        {
           // await App.Current.MainPage.Navigation.PopModalAsync();
            StateBag.ADALHelper.IsFingerPrintAuthentication();
            
        }


        async void ButtonLogin_ClickedAsync(object sender, EventArgs e)
        {
            //await App.Current.MainPage.Navigation.PopModalAsync();
            try
            {
                msg("ADAL API Constants: " + APIConstants.Dump());
                msg("RedirUri: " + StateBag.ADALHelper.GetADALRedirUrl());
                // msg("chirp");
                AuthenticationResult authResult = await
                    StateBag.ADALHelper.AuthenticateAsync(
                        APIConstants.Authority,
                        APIConstants.GraphResourceUri,
                        APIConstants.ClientId,
                        StateBag.ADALHelper.GetADALRedirUrl()
                    );

                StateBag.AuthResult = authResult;
                msg(authResult.ToDebugString());
            }
            catch (Exception ex)
            {
                string exstuff = ex.ToString();
                if (exstuff.Contains("authentication_ui_failed"))
                {
                    await EnlivenLoginPage.DisplayAlert("authentication_ui_failed", "try changing your SSL/TLS Implementation from Default to Managed TLS 1.1 under Android Options > Advanced > SSL/TLS Implementation", "eeek");
                }
                System.Diagnostics.Debug.WriteLine("!!! " + ex.ToString());
                msg("exception on login: " + ex.ToString());
            }
        }

        async void SwitchPageAsync()
        {
          
                await App.Current.MainPage.Navigation.PushModalAsync(EnlivenLoginPage); // = EnlivenLoginPage;
        }
        private void msg(string msg, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            if (string.IsNullOrEmpty(msg)) return;

          TapHereLabel.Text += $"{Environment.NewLine}{memberName}: {msg}";
        }
    }
}
