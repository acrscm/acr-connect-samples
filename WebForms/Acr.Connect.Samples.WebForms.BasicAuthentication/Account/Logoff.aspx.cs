using System;
using System.Web;
using System.Web.UI;
using Acr.Connect.Owin.Security.Oidc;
using Microsoft.AspNet.Identity;

namespace Acr.Connect.Samples.WebForms.BasicAuthentication.Account
{
    public partial class Logoff : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(
                DefaultAuthenticationTypes.ApplicationCookie, 
                DefaultAuthenticationTypes.ExternalCookie,
                AcrConnectOidcAuthenticationOptions.DefaultAuthenticationType);
        }
    }
}