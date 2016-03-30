using System;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Acr.Connect.Security.Common;
using Acr.Connect.Security.Gui;
using Acr.Connect.WinForms.Sample.Properties;

namespace Acr.Connect.WinForms.Sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var settings = Settings.Default;

            ClientId.Text = settings.ClientId;
            ClientSecret.Text = settings.ClientSecret;
            AuthServiceUrl.Text = settings.AuthenticationServiceUrl;
            IdpName.Text = settings.IdentityProviderName;
            RedirectUrl.Text = settings.RedirectUrl;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            DecodedIdToken.Text = string.Empty;
            IdToken.Text = string.Empty;

            _acrConnectOidcLogOnControl.AuthenticationServiceBaseUrl = new Uri(AuthServiceUrl.Text);
            _acrConnectOidcLogOnControl.ClientId = ClientId.Text;
            _acrConnectOidcLogOnControl.ClientSecret = ClientSecret.Text.ToSecureString();
            _acrConnectOidcLogOnControl.RedirectUrl = new Uri(RedirectUrl.Text);
            _acrConnectOidcLogOnControl.IdentityProviderName = IdpName.Text;
            _acrConnectOidcLogOnControl.RequestTokens = RequestTokens.Checked;
            _acrConnectOidcLogOnControl.SignInUser = SignInUser.Checked;
            _acrConnectOidcLogOnControl.IssuerSigningKey = new X509AsymmetricSecurityKey(new X509Certificate2(Resources.AcrConnectCertificate));

            _acrConnectOidcLogOnControl.SignIn();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            AuthCode.Text = string.Empty;
            AccessToken.Text = string.Empty;
            DecodedIdToken.Text = string.Empty;
            IdToken.Text = string.Empty;

            _acrConnectOidcLogOnControl.SignOut();
        }

        private void AcrConnectOidcLogonControl_Authenticated(object sender, AuthenticatedEventArgs e)
        {
            DecodedIdToken.Text = e.JwtToken.ToString();
        }

        private void AcrConnectOidcLogonControl_TokenReceived(object sender, TokenReceivedEventArgs e)
        {
            IdToken.Text = e.OidcMessage.IdToken;
            AccessToken.Text = e.OidcMessage.AccessToken;
            RefreshToken.Text = e.OidcMessage.Token;
        }

        private void AcrConnectOidcLogonControl_AuthCodeReceived(object sender, AuthCodeReceivedEventArgs e)
        {
            AuthCode.Text = e.OidcMessage.Code;
        }
    }
}
