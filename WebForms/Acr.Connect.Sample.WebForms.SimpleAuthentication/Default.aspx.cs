using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using Acr.Connect.Owin.Security.Oidc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Acr.Connect.Sample.WebForms.SimpleAuthentication
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack) return;

            if (Context.GetOwinContext().Authentication.User.Identity.IsAuthenticated)
            {
                LoginButton.Visible = false;
                LogoffButton.Visible = true;
                Label.Text = Context.GetOwinContext().Authentication.User.Identity.Name;
            }
            else
            {
                LoginButton.Visible = true;
                LogoffButton.Visible = false;
                Label.Text = string.Empty;

                var loginInfo = Context.GetOwinContext().Authentication.GetExternalLoginInfo();
                if(loginInfo == null) return;

                var user = ConvertToAppUser(loginInfo);
                Context.GetOwinContext().Authentication.SignIn(user);
                Response.Redirect("~/");
            }
        }

        private static ClaimsIdentity ConvertToAppUser(ExternalLoginInfo loginInfo)
        {
            var user = new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, loginInfo.Login.ProviderKey),
                new Claim(ClaimTypes.Name, loginInfo.Login.ProviderKey)
            }, DefaultAuthenticationTypes.ApplicationCookie);

            return user;
        }

        protected void LoginButton_OnClick(object sender, EventArgs e)
        {
            var properties = new AuthenticationProperties { RedirectUri = ResolveUrl("~/") };
            Context.GetOwinContext().Authentication.Challenge(properties, AcrConnectOidcAuthenticationOptions.DefaultAuthenticationType);
            Response.StatusCode = 401;
            Response.End();
        }

        protected void LogoffButton_OnClick(object sender, EventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(
                DefaultAuthenticationTypes.ApplicationCookie,
                DefaultAuthenticationTypes.ExternalCookie,
                AcrConnectOidcAuthenticationOptions.DefaultAuthenticationType);
        }
    }
}