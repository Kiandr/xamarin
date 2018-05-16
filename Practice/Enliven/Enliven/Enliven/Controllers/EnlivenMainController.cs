using System.Reflection;
using Xamarin.Forms;

namespace Enliven.Controllers
{
	internal class EnlivenMainController
	{
		private Page EnlivenParentPage { get; set; }

	    public Page GetEnlivenParentPage()
	    {
	        return EnlivenParentPage?? new ContentPage();
	    }

	    public EnlivenMainController()
	    {

         // if user has access to app
	     EnlivenParentPage = new EnlivenSplashController().GetEnlivenSplashController();

         // if user does not have acces to app
	     // EnlivenPrentPage = login page :-)

	    }

	}
}

