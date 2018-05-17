namespace Enliven.Controllers
{
     public abstract class  EnlivenBaseController
     {
        protected EnlivenBaseController()
        {
        }

        protected EnlivenBaseController(string currentView)
        {
            CurrentView = currentView;
        }

        protected string CurrentView { get; set; }

     }


}
