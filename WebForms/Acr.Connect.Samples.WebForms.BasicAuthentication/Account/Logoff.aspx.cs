using System;
using System.Web.UI;
using Acr.Connect.Security.Common;

namespace Acr.Connect.Samples.WebForms.BasicAuthentication.Account
{
    public partial class Logoff : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var baseUrl = new Uri(Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/");
            using (var iodcOptions = new OidcOptions { AuthenticationServiceBaseUrl = SettingsProvider.AuthServiceBaseUrl })
            {
                var acrConnectLogoffUrl = iodcOptions.BuildSignOutUrl(baseUrl);
                Response.Redirect(acrConnectLogoffUrl.AbsoluteUri);
            }
        }
    }
}