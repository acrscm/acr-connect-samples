using System;
using Acr.Connect.Owin.Security.Oidc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Acr.Connect.Samples.WebForms.BasicAuthentication.Models;

namespace Acr.Connect.Samples.WebForms.BasicAuthentication
{
    public partial class Startup {

        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            ConfigureAcrConnect(app);

            ConfigureCookieAuth(app);
        }

        private static void ConfigureAcrConnect(IAppBuilder app)
        {
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            var saOptions = new AcrConnectOidcAuthenticationOptions
            {
                IssuerName             = SettingsProvider.IssuerName,
                CallbackPath           = new PathString("/account/accesstoken"),
                ClientId               = SettingsProvider.ClientId,
                ClientSecret           = SettingsProvider.ClientSecret,
                RealmUrl               = SettingsProvider.AuthServiceBaseUrl,
                PostLogOffRedirectPath = new PathString("/Default.aspx"),
                IssuerSigningKey       = SettingsProvider.AcrConnectSigninKey,
                
            };

            app.UseAcrConnectOidcAuthentication(saOptions);
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
    }
}
