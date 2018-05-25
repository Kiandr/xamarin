using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enliven.Interfacess;
using Foundation;
using LocalAuthentication;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(Enliven.iOS.ADALHelper))]
namespace Enliven.iOS
{
	public class ADALHelper : IADALHelper
	{
		public async Task<AuthenticationResult> AuthenticateAsync(string authority, string resource, string clientId, string returnUri)
		{
			var authContext = new AuthenticationContext(authority);
			if (authContext.TokenCache.ReadItems().Any())
				authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);
			//var controller = UIApplication.SharedApplication.KeyWindow.RootViewController;
			//// jhealy: maybe platformparams here is what's wrong with other one?
			//var platformParams = new PlatformParameters(controller);
			//var window = UIApplication.SharedApplication.KeyWindow;

			var window = UIApplication.SharedApplication.KeyWindow;
			var vc = window.RootViewController;

			var authResult = await authContext.AcquireTokenAsync(
				resource,
				clientId,
				new System.Uri(returnUri),
				new PlatformParameters(vc.ModalViewController)
			);

			return authResult;
		}

		public IPlatformParameters GetPlatformParameters()
		{

			var window = UIApplication.SharedApplication.KeyWindow;
			var vc = window.RootViewController;

			return new PlatformParameters(vc.PresentedViewController);
		}

		private string m_RedirUrl { get; set; } = @"https://enliven";
		public System.Uri GetRedirectUri()
		{
			;
			return new Uri(m_RedirUrl);
		}

		public string GetADALRedirUrl()
		{
			return m_RedirUrl;
		}

		public string GetWebAPIRedirUrl()
		{
			return m_RedirUrl;
		}

		public void Logout(string authority)
		{
			AuthenticationContext authContext = new AuthenticationContext(authority);
			authContext.TokenCache.Clear();
			authContext.TokenCache.Clear();
			Foundation.NSHttpCookieStorage cookieStorage = Foundation.NSHttpCookieStorage.SharedStorage;
			foreach (var cookie in cookieStorage.Cookies)
			{
				cookieStorage.DeleteCookie(cookie);
			}
		}
		public async Task<bool> IsFingerPrintAuthentication()
		{

			var ctxt = new LAContext();
			var error = new NSError();
			if (ctxt.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out error))
			{
				var authenticated = await ctxt.EvaluatePolicyAsync(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, "Authenticate to confirm message");
				if (authenticated.Item1 == true)

					return true;



			}
			return false;
		}
	}
}
