using Xamarin.Forms;
using Label = Xamarin.Forms.Label;

namespace Phone.Views
{
    public class PreBuiltEnlivenContentPage : ContentPage
    {
        /// <summary>
        /// private locker for single tone operation
        /// </summary>
        private bool Locker { get; } = false;

        /// <summary>
        /// The public property available via a public getter method. 
        /// </summary>
        private ContentPage PrePopPageContent { get; set; }

        /// <summary>
        /// SingleTonePage
        /// </summary>
        /// <param name="prePopPageContent"></param>
        public PreBuiltEnlivenContentPage(ContentPage prePopPageContent)
        {
            // Single Tone Locker
            if (PrePopPageContent != null)
            {
                return;
            }

            if (Locker != false)
            {
                return;
            }

            Locker = true;
            PrePopPageContent = prePopPageContent;
        }
        /// <summary>
        /// public parameterless constructor
        /// </summary>
        public PreBuiltEnlivenContentPage()
        {
            this.PrePopPageContent = new ContentPage(){Content = new Label
                {
                    Text = "Hello, Enliven First PreBuilt Content Page!",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    BackgroundColor = Color.DarkGreen
                }
            };
        }
        /// <summary>
        /// public getter to get the pre built screen
        /// </summary>
        /// <returns></returns>
        public ContentPage  GetPreBuiltEnlivenContentPage()
        {
            return PrePopPageContent;
        }
    }
}

	
	
