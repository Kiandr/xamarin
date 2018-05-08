using Xamarin.Forms;

namespace Phone
{
    public class MainEnlivenPage : MainPage
    {
        private ContentPage StartPage
        {
            get
            {
                var mainEnlivenPage = this;
                return mainEnlivenPage;
            }
        }

        public MainEnlivenPage()
        {
             this.StartPage.Content = new Label() { Text = "Welcome John", MinimumHeightRequest = 40, AnchorX = 0, AnchorY = 0, BackgroundColor = Color.Blue, FontSize = 40 };
        }

        public ContentPage GetStartPage()
        {
            return StartPage;
        }
    } 

}
