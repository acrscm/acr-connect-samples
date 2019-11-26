using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Acr.Connect.Samples.WinForms.RefreshToken.Properties;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;

namespace Acr.Connect.Samples.WinForms.RefreshToken
{
    public partial class MainForm : Form, ILogger
    {
        private OidcClient _oidcClient;

        public MainForm()
        {
            InitializeComponent();

            var settings = Settings.Default;

            ClientId.Text = settings.ClientId;
            AuthServiceUrl.Text = settings.AuthorityUrl;
            RedirectUrl.Text = settings.RedirectUrl;
            Scope.Text = settings.Scope;

            var options = new OidcClientOptions
            {
                Authority = settings.AuthorityUrl,
                ClientId = settings.ClientId,
                Scope = settings.Scope,
                RedirectUri = settings.RedirectUrl,
                Flow = OidcClientOptions.AuthenticationFlow.AuthorizationCode,
                Browser = new BrowserPopup(this),
                LoadProfile = true,
            };

            /// Issuer name validation is disabled at the discovety since IDP Name and Authority URL do not match in current configuration. 
            /// However, IDP Name still has to be validated during token validation.
            options.Policy.Discovery.ValidateIssuerName = false;

            options.Policy.Discovery.AuthorityNameComparison = StringComparison.InvariantCultureIgnoreCase;

            _oidcClient = new OidcClient(options);
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            ClearTokenTextBoxes();

            _oidcClient.Options.Authority = AuthServiceUrl.Text;
            _oidcClient.Options.ClientId = ClientId.Text;
            _oidcClient.Options.Scope = Scope.Text;
            _oidcClient.Options.RedirectUri = RedirectUrl.Text;
            _oidcClient.Options.Policy.Discovery.ValidateEndpoints = false;
            _oidcClient.Options.Flow = OidcClientOptions.AuthenticationFlow.AuthorizationCode;
            _oidcClient.Options.ResponseMode = OidcClientOptions.AuthorizeResponseMode.Redirect;

            var result = await _oidcClient.LoginAsync(new LoginRequest { BrowserDisplayMode = DisplayMode.Visible });

            if (result.IsError)
            {
                MessageBox.Show(this, result.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshToken.Text = result.RefreshToken;
                AccessToken.Text = result.AccessToken;
                IdToken.Text = result.IdentityToken;
                UserClaims.Text = string.Join(Environment.NewLine, result.User.Claims.Select(c=>$"{c.Type}: {c.Value}").ToArray());
            }
        }

        private async void SignOutButton_Click(object sender, EventArgs e)
        {
            LogoutRequest logoutRequest = new LogoutRequest
            {
                IdTokenHint = IdToken.Text, BrowserDisplayMode = DisplayMode.Visible
            } ;
            await _oidcClient.LogoutAsync(logoutRequest);
            ClearTokenTextBoxes();
        }

        private void ClearTokenTextBoxes()
        {
            RefreshToken.Text = AccessToken.Text = IdToken.Text = UserClaims.Text = string.Empty;
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RefreshToken.Text, TextDataFormat.Text);
        }

        private void CopyAccessTokenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(AccessToken.Text, TextDataFormat.Text);
        }

        private void CopyIdTokenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IdToken.Text, TextDataFormat.Text);
        }

        private void ClearTokens_Click(object sender, EventArgs e)
        {
            ClearTokenTextBoxes();
        }

        public void Log(string eventName, string message)
        {
            using (var log = new StreamWriter("Log.txt", true))
            {
                log.WriteLine($"{DateTime.Now}:{eventName} - {message}");
                log.Flush();
            }
        }
    }
}
