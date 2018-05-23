﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web.Http.Filters;
using Enliven.Interfacess;
using Microsoft.IdentityModel.Clients.ActiveDirectory;


[assembly: Xamarin.Forms.Dependency(typeof(Enliven.UWP.ADALHelper))]
namespace Enliven.UWP
{
    public class ADALHelper : IADALHelper
    {
        public async Task<AuthenticationResult> AuthenticateAsync(string authority, string resource, string clientId, string returnUri)
        {
            var authContext = new AuthenticationContext(authority);
            if (authContext.TokenCache.ReadItems().Any())
                authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);

            var uri = new System.Uri(returnUri);

            var platformParams = GetPlatformParameters();

            var authResult = await authContext.AcquireTokenAsync(resource, clientId, uri, platformParams);
            return authResult;
        }

        private string m_ADALRedirectUrl = "https://enliven";
        public string GetADALRedirUrl()
        {
            if (string.IsNullOrWhiteSpace(m_ADALRedirectUrl))
            {
                m_ADALRedirectUrl = Windows.Security.Authentication.Web.WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString();
            }
            return m_ADALRedirectUrl;
        }

        public void Logout(string authority)
        {
            AuthenticationContext authContext = new AuthenticationContext(authority);
            var filter = new HttpBaseProtocolFilter();
            filter.ClearAuthenticationCache();
            authContext.TokenCache.Clear();
            HttpCookieCollection myCookies = filter.CookieManager.GetCookies(new System.Uri(authority));
            foreach (HttpCookie cookie in myCookies)
            {
                filter.CookieManager.DeleteCookie(cookie);
            }
        }

        public IPlatformParameters GetPlatformParameters()
        {
            return new PlatformParameters(PromptBehavior.Auto, false);
        }
    }
}
