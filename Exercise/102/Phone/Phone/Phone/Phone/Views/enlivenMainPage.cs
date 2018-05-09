using System;
using Phone.Views;
using Xamarin.Forms;

namespace Phone
{
    public class MainEnlivenPage : MainPage
    {
        /// <summary>
        /// Single tone content page
        /// </summary>
        private ContentPage StartPage { get; set; }
    

        /// <summary>
        /// Single tone Master Detail page
        /// </summary>
        private MasterDetailPage EnlivenMasterDetailPage {
            get
            {
                var masterDetailPage = new MasterDetailPage();
               
                return masterDetailPage;
            }

        }

        /// <summary>
        /// Table page 
        /// </summary>
        private TabbedPage EnlivenTabbedPage
        {
            get
            {
                var tablePage = new TabbedPage();
                return tablePage;
            }
        }

        /// <summary>
        /// Single tone carousel page
        /// </summary>
        private CarouselPage EnlivenCarouselPage {
            get
            {
                var carouselPage = new CarouselPage();
                return carouselPage;
            }
        }

        /// <summary>
        /// Single tone navigation page
        /// </summary>
        private NavigationPage EnlivenNavigationPage
        {
            get
            {
                var navigationPage = new NavigationPage();
                return navigationPage;
            }
        }


        /// <summary>
        /// Constructor 
        /// </summary>
        public MainEnlivenPage()
        {
            // this.StartPage.Content = new Label() { Text = "Welcome John", MinimumHeightRequest = 40, AnchorX = 0, AnchorY = 0, BackgroundColor = Color.Blue, FontSize = 40 };
            //this.StartPage = new PreBuiltEnlivenContentPage().GetPreBuiltEnlivenContentPage();
            this.StartPage = new PreBuiltEnlivenMasterDetailPageDetail();
        }

        public ContentPage GetStartPage()
        {
            return StartPage;
        }
    } 

}
