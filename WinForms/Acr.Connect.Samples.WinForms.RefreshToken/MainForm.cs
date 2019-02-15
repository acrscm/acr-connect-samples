using System;
using System.Windows.Forms;
using Acr.Connect.Samples.WinForms.RefreshToken.Properties;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;

namespace Acr.Connect.Samples.WinForms.RefreshToken
{
    public partial class MainForm : Form
    {
        private OidcClient _oidcClient;

        public MainForm()
        {
            InitializeComponent();

            var settings = Settings.Default;

            ClientId.Text = settings.ClientId;
            ClientSecret.Text = settings.ClientSecret;
            AuthServiceUrl.Text = settings.AuthorityUrl;
            RedirectUrl.Text = settings.RedirectUrl;
            Scope.Text = settings.Scope;


            var options = new OidcClientOptions
            {
                Authority = settings.AuthorityUrl,
                ClientId = settings.ClientId,
                ClientSecret = settings.ClientSecret,
                Scope = settings.Scope,
                RedirectUri = settings.RedirectUrl,
                Flow = OidcClientOptions.AuthenticationFlow.AuthorizationCode,
                Browser = new BrowserPopup()
            };

            options.Policy.Discovery.ValidateIssuerName = false;

            _oidcClient = new OidcClient(options);
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            ClearTokenTextBoxes();

            var result = await _oidcClient.LoginAsync(new LoginRequest { BrowserDisplayMode = DisplayMode.Visible });

            if (result.IsError)
            {
                MessageBox.Show(this, result.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshToken.Text = result.RefreshToken;
            }
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            ClearTokenTextBoxes();
        }

        private void ClearTokenTextBoxes()
        {
            RefreshToken.Text = string.Empty;
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RefreshToken.Text, TextDataFormat.Text);
        }
    }
}
