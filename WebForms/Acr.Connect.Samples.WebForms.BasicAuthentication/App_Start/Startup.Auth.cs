﻿using System;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Web;
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

            var certificate = HttpContext.Current.Server.MapPath("~/AcrConnect.cer");
            var cert = new X509Certificate2(certificate);

            var saOptions = new AcrConnectOidcAuthenticationOptions
            {
                IssuerName = "https://acr-id-test.acr.org/SecureAuth17",
                CallbackPath = new PathString("/account/accesstoken"),
                ClientId = "c3b97253202a426390cccfac755dc80c",
                ClientSecret = "a596fb52d41749b092cfcda57cf6197b",
                RealmUrl = new Uri("https://acr-id-test.acr.org/acrid-userlogin/"),
                PostLogOffRedirectPath = new PathString("/Default.aspx"),
                IssuerSigningKey = new X509AsymmetricSecurityKey(cert)
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
