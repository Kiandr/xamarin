using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Hardware.Fingerprint;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Enliven.Interfacess;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(Enliven.Droid.ADALHelper))]
namespace Enliven.Droid
{
	public class ADALHelper : IADALHelper
	{
		public async Task<AuthenticationResult> AuthenticateAsync(string authority, string resource, string clientId, string returnUri)
		{
			var authContext = new AuthenticationContext(authority);
			if (authContext.TokenCache.ReadItems().Any())
				authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);

#pragma warning disable CS0618 // 'Forms.Context' is obsolete: 'Context is obsolete as of version 2.5. Please use a local context instead.'
			var platformParams = new PlatformParameters((Activity)Forms.Context);
#pragma warning restore CS0618 // 'Forms.Context' is obsolete: 'Context is obsolete as of version 2.5. Please use a local context instead.'

			var authResult = await authContext.AcquireTokenAsync(
				resource,
				clientId,
				new System.Uri(returnUri),
				platformParams);

			return authResult;
		}

		public static MainActivity MyMainActivity { get; set; } = null;
		public static void Init(MainActivity myMainActivity)
		{
			MyMainActivity = myMainActivity;
		}

		public IPlatformParameters GetPlatformParameters()
		{
			if (MyMainActivity == null)
			{
				throw new Exception("Android.ADALHelper.GetPlatformParameters.  MyMainActivity is null.");
			}
			return new PlatformParameters(MyMainActivity);
		}

		public int IsFingerPrintAuthentication()
		{

			FingerprintManagerCompat fingerprintManager = FingerprintManagerCompat.From(Android.App.Application.Context);
			if (!fingerprintManager.IsHardwareDetected)
			{
				return 1;
			}

			return 0;

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
			CookieManager.Instance.RemoveAllCookie();
		}

		Task<bool> IADALHelper.IsFingerPrintAuthentication()
		{
			throw new NotImplementedException();
		}
	}
}
