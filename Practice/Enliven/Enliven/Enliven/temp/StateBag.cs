using Enliven.Interfacess;
//using Enliven.UWP;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;

namespace Enliven.temp
{
    public static class StateBag
    {
        public static AuthenticationResult AuthResult { get; set; } = null;

        private static IADALHelper m_ADALHelper = null;
        public static IADALHelper ADALHelper
        {
            get
            {
                if (m_ADALHelper == null)
                {
                    //m_ADALHelper = new ADALHelper();
                    m_ADALHelper = DependencyService.Get<IADALHelper>();
                }
                return m_ADALHelper;
            }
        }
    }
}
