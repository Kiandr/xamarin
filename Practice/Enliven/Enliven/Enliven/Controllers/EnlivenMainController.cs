using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
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
            var layout = new StackLayout();
            var button = new Button
            {
                Text = "StackLayout",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var yellowBox = new BoxView { Color = Color.Yellow, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            var greenBox = new BoxView { Color = Color.Green, VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            var blueBox = new BoxView
            {
                Color = Color.Blue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75
            };

            layout.Children.Add(button);
            layout.Children.Add(yellowBox);
            layout.Children.Add(greenBox);
            layout.Children.Add(blueBox);
            layout.Spacing = 10;

            
            EnlivenMainPage = new ContentPage() {Content =  layout};
        }

    }
}
