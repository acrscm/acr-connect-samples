using System;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Acr.Connect.Samples.WebForms.BasicAuthentication
{
    public static class SettingsProvider
    {
        public static Uri AuthServiceBaseUrl
        {
            get { return new Uri(ConfigurationManager.AppSettings["AcrConnect.AuthServiceBaseUrl"]); }
        }

        public static string IssuerName
        {
            get { return ConfigurationManager.AppSettings["AcrConnect.IssuerName"]; }
        }

        public static string ClientId
        {
            get { return ConfigurationManager.AppSettings["AcrConnect.ClientID"]; }
        }

        public static string ClientSecret
        {
            get { return ConfigurationManager.AppSettings["AcrConnect.ClientSecret"]; }
        }

        public static SecurityKey AcrConnectSigninKey
        {
            get
            {
                var certificate = HttpContext.Current.Server.MapPath("~/AcrConnect.cer");
                var cert = new X509Certificate2(certificate);
                return new X509AsymmetricSecurityKey(cert);
            }
        }
    }
}