using System;
using System.Web;
using Acr.Connect.Samples.WebForms.RefreshToken.Properties;
using Acr.Connect.Security.Common;
using Microsoft.IdentityModel.Protocols;
using Thinktecture.IdentityModel.Client;

namespace Acr.Connect.Samples.WebForms.RefreshToken
{
    public partial class Connect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                var settigs = Settings.Default;
                AuthenticationServiceUrl.Text = settigs.AuthenticationServiceUrl;
                ClientId.Text = settigs.ClientId;
                ClientSecret.Text = settigs.ClientSecret;
                RedirectUrl.Text = settigs.RedirectUrl;
                Scope.Text = settigs.Scope;
            }

            var oidcMessage = new OpenIdConnectMessage(HttpUtility.ParseQueryString(Request.Url.Query));
            if (string.IsNullOrEmpty(oidcMessage.Code)) return;

            RequestsTokensByCode(oidcMessage.Code);
        }

        protected void OnClick(object sender, EventArgs e)
        {
            RedirectToAuthenticationEndpont();
        }

        protected void GetAccessTokenButton_OnClick(object sender, EventArgs e)
        {
            RequestTokensByRefreshToken(RefreshToken.Text);
        }

        private void RedirectToAuthenticationEndpont()
        {
            using (var acrIdSingInOptions = new OidcOptions())
            {
                acrIdSingInOptions.AuthenticationServiceBaseUrl = new Uri(AuthenticationServiceUrl.Text, UriKind.Absolute);
                acrIdSingInOptions.ClientId = ClientId.Text;
                acrIdSingInOptions.RedirectUri = new Uri(RedirectUrl.Text, UriKind.Absolute);
                acrIdSingInOptions.Scope = Scope.Text;

                Response.Redirect(acrIdSingInOptions.SignInUrl.OriginalString);
            }
        }

        private void RequestsTokensByCode(string authCode)
        {
            using (var acrIdSingInOptions = new OidcOptions())
            {
                acrIdSingInOptions.AuthenticationServiceBaseUrl = new Uri(AuthenticationServiceUrl.Text, UriKind.Absolute);

                var client = new OAuth2Client(acrIdSingInOptions.TokenEndpointUrl, ClientId.Text, ClientSecret.Text,
                    OAuth2Client.ClientAuthenticationStyle.PostValues);
                var tokenResponse = client.RequestAuthorizationCodeAsync(authCode, RedirectUrl.Text).Result;

                RefreshToken.Text = tokenResponse.RefreshToken;
                GetAccessTokenButton.Enabled = !string.IsNullOrEmpty(tokenResponse.RefreshToken);
            }
        }

        private void RequestTokensByRefreshToken(string refreshToken)
        {
            using (var acrIdSingInOptions = new OidcOptions())
            {
                acrIdSingInOptions.AuthenticationServiceBaseUrl = new Uri(AuthenticationServiceUrl.Text, UriKind.Absolute);

                var client = new OAuth2Client(acrIdSingInOptions.TokenEndpointUrl, ClientId.Text, ClientSecret.Text,
                    OAuth2Client.ClientAuthenticationStyle.PostValues);
                var tokenResponse = client.RequestRefreshTokenAsync(refreshToken).Result;

                RefreshToken.Text = tokenResponse.RefreshToken;
                AccessToken.Text = tokenResponse.AccessToken;
            }
        }
    }
}