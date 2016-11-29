using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Acr.Connect.Sample.WebForms.SimpleAuthentication
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.GetOwinContext().Authentication.User.Identity.IsAuthenticated)
            {
                LoginButton.Visible = false;
                Label.Text = Context.GetOwinContext().Authentication.User.Identity.Name;
                return;
            }

            var loginInfo = Context.GetOwinContext().Authentication.GetExternalLoginInfo();
            if (loginInfo != null)
            {
                var user = ConvertToAppUser(loginInfo);
                Context.GetOwinContext().Authentication.SignIn(user);
                Response.Redirect("~/");
            }

            LoginButton.Visible = true;
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
            Context.GetOwinContext().Authentication.Challenge(properties, "ACR ID");
            Response.StatusCode = 401;
            Response.End();
        }
    }
}