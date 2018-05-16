using Enliven.Controllers;
using Xamarin.Forms;

namespace Enliven
{
    class App:Application
    {
        public App()
        {
            MainPage = new EnlivenMainController().GetEnlivenParentPage();

        }
    }
}
