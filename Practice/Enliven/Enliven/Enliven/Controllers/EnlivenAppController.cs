using System;
using System.Collections.Generic;
using System.Text;

namespace Enliven.Controllers
{
    internal class EnlivenAppController : EnlivenBaseController
    {
        protected EnlivenAppController()
        {
        }

        protected EnlivenAppController(string currentView) : base(currentView)
        {
        }
    }
}
