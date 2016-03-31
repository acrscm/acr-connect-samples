using System;
using System.Windows.Forms;
using Acr.Connect.Security.Common;
using Acr.Connect.Security.Gui;
using Acr.Connect.WinForms.RefreshTokenSample.Properties;

namespace Acr.Connect.WinForms.RefreshTokenSample
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
            RedirectUrl.Text = settings.RedirectUrl;
            Scope.Text = settings.Scope;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            ClearTokenTextBoxes();

            _acrConnectOidcLogOnControl.AuthenticationServiceBaseUrl = new Uri(AuthServiceUrl.Text);
            _acrConnectOidcLogOnControl.ClientId = ClientId.Text;
            _acrConnectOidcLogOnControl.ClientSecret = ClientSecret.Text.ToSecureString();
            _acrConnectOidcLogOnControl.RedirectUrl = new Uri(RedirectUrl.Text);
            _acrConnectOidcLogOnControl.RequestTokens = true;
            _acrConnectOidcLogOnControl.Scope = Scope.Text;

            _acrConnectOidcLogOnControl.SignIn();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            ClearTokenTextBoxes();

            _acrConnectOidcLogOnControl.SignOut();
        }

        private void AcrConnectOidcLogonControl_TokenReceived(object sender, TokenReceivedEventArgs e)
        {
            RefreshToken.Text = e.OidcMessage.Token;
        }

        private void AcrConnectOidcLogonControl_AuthCodeReceived(object sender, AuthCodeReceivedEventArgs e)
        {
            AuthCode.Text = e.OidcMessage.Code;
        }

        private void ClearTokenTextBoxes()
        {
            AuthCode.Text = string.Empty;
            RefreshToken.Text = string.Empty;
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RefreshToken.Text, TextDataFormat.Text);
        }
    }
}
