using System;
using System.Net.Http;
using System.Windows.Forms;
using Acr.Connect.Samples.WinForms.AccessToken.Properties;
using IdentityModel.Client;

namespace Acr.Connect.Samples.WinForms.AccessToken
{
    public partial class MainForm : Form
    {
        private HttpClient _client = new HttpClient();

        public MainForm()
        {
            InitializeComponent();

            AuthServiceUrl.Text = Settings.Default.AuthenticationServiceUrl;
            ClientId.Text = Settings.Default.ClientId;
            ClientSecret.Text = Settings.Default.ClientSecret;
        }

        private async void GetAccessTokenButton_Click(object sender, EventArgs e)
        {
            var request = new RefreshTokenRequest
            {
                Address = AuthServiceUrl.Text,
                ClientId = ClientId.Text,
                ClientSecret = ClientSecret.Text,
                RefreshToken = RefreshToken.Text
            };

            var response = await _client.RequestRefreshTokenAsync(request);

            RefreshToken.Text = response.RefreshToken;
            AccessToken.Text = response.AccessToken;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _client.Dispose();

            base.OnFormClosed(e);
        }
    }
}
