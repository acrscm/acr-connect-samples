using System;
using System.Windows.Forms;
using Acr.Connect.Samples.WinForms.AccessToken.Properties;
using Acr.Connect.Security.Common;
using Thinktecture.IdentityModel.Client;

namespace Acr.Connect.Samples.WinForms.AccessToken
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AuthServiceUrl.Text = Settings.Default.AuthenticationServiceUrl;
            ClientId.Text = Settings.Default.ClientId;
            ClientSecret.Text = Settings.Default.ClientSecret;

        }

        private async void GetAccessTokenButton_Click(object sender, EventArgs e)
        {
            using (var oidcOptions = new OidcOptions())
            {
                oidcOptions.AuthenticationServiceBaseUrl = new Uri(AuthServiceUrl.Text, UriKind.Absolute);
                var oauthClient = new OAuth2Client(oidcOptions.TokenEndpointUrl, ClientId.Text, ClientSecret.Text, OAuth2Client.ClientAuthenticationStyle.PostValues);
                var tokenResponse = await oauthClient.RequestRefreshTokenAsync(RefreshToken.Text);

                RefreshToken.Text = tokenResponse.RefreshToken;
                AccessToken.Text = tokenResponse.AccessToken;
            }
        }
    }
}
