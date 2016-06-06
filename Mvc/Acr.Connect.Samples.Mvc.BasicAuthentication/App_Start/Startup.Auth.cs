using System;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Acr.Connect.Owin.Security.Oidc;
using Acr.Connect.Samples.Mvc.BasicAuthentication.Auth;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Acr.Connect.Samples.Mvc.BasicAuthentication.Models;
using Acr.Connect.Samples.Mvc.BasicAuthentication.Properties;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(DemoDbContext.Create);
            app.CreatePerOwinContext<DemoUserManager>(DemoUserManager.Create);
            app.CreatePerOwinContext<DemoSignInManager>(DemoSignInManager.Create);

            ConfigureAcrConnect(app);
            ConfigureCookieAuth(app);
        }

        private static void ConfigureCookieAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Index"),
                SlidingExpiration = true,
                ExpireTimeSpan = TimeSpan.FromMinutes(2)
            });
        }

        private static void ConfigureAcrConnect(IAppBuilder app)
        {
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            var certificate = HttpContext.Current.Server.MapPath("~/AcrConnect.cer");
            var cert = new X509Certificate2(certificate);

            var saOptions = new AcrConnectOidcAuthenticationOptions
            {
                IssuerName = Settings.Default.IdentityProviderName,
                CallbackPath = new PathString(Settings.Default.CallbackPath),
                ClientId = Settings.Default.ClientId,
                ClientSecret = Settings.Default.ClientSecret,
                RealmUrl = new Uri(Settings.Default.AuthenticationServiceUrl),
                PostLogOffRedirectPath = new PathString("/Home/Index"),
                IssuerSigningKey = new X509AsymmetricSecurityKey(cert)
            };

            app.UseAcrConnectOidcAuthentication(saOptions);
        }
    }
}