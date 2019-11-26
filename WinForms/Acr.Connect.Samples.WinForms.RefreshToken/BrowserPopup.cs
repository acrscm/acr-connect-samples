using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;

namespace Acr.Connect.Samples.WinForms.RefreshToken
{
    internal class BrowserPopup : IBrowser
    {
        private readonly ILogger _logger;

        public BrowserPopup(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<BrowserResult> InvokeAsync(BrowserOptions options)
        {
            using (var form = new Form { Name = "WebAuthentication", Text = "Authenticating...", Width = 1024, Height = 768 })
            using (var browser = new WebBrowserEx()
            {
                ScriptErrorsSuppressed = true,
                Dock = DockStyle.Fill
            })
            {
                var signal = new SemaphoreSlim(0, 1);

                var result = new BrowserResult
                {
                    ResultType = BrowserResultType.UserCancel
                };

                form.FormClosed += (o, e) =>
                {
                    signal.Release();
                };

                browser.NavigateError += (o, e) =>
                {
                    Log("NavigateError", e.Url);
                    if (e.StatusCode == 302) return;

                     e.Cancel = true;
                    if (!string.IsNullOrEmpty(options.EndUrl) && e.Url.StartsWith(options.EndUrl) && options.ResponseMode == OidcClientOptions.AuthorizeResponseMode.Redirect)
                    {
                        result.ResultType = BrowserResultType.Success;
                        result.Response = e.Url;
                    }
                    else
                    {
                        result.ResultType = BrowserResultType.HttpError;
                        result.Error = e.StatusCode.ToString();
                    }
                    signal.Release();
                };

                browser.Navigating += (o, e) =>
                {
                    Log("Navigating", e.Url);
                };

                browser.Navigated += (o, e) =>
                {
                    Log("Navigated", e.Url);
                    if (!string.IsNullOrEmpty(options.EndUrl) && e.Url.OriginalString.StartsWith(options.EndUrl) && options.ResponseMode == OidcClientOptions.AuthorizeResponseMode.Redirect)
                    {
                        result.ResultType = BrowserResultType.Success;
                        result.Response = e.Url.OriginalString;
                        signal.Release();
                    }
                };

                browser.BeforeNavigate2 += (o, e) =>
                {
                    Log("BeforeNavigate2", e.Url);
                    if (!string.IsNullOrEmpty(options.EndUrl) && e.Url.StartsWith(options.EndUrl))
                    {
                        e.Cancel = true;
                        result.ResultType = BrowserResultType.Success;
                        if (options.ResponseMode == OidcClientOptions.AuthorizeResponseMode.FormPost)
                        {
                            result.Response = Encoding.UTF8.GetString(e.PostData ?? new byte[] { }).TrimEnd('\0');
                        }
                        else
                        {
                            result.Response = e.Url;
                        }
                        signal.Release();
                    }
                };

                form.Controls.Add(browser);
                browser.Show();

                System.Threading.Timer timer = null;

                form.Show();

                browser.Navigate(options.StartUrl);

                await signal.WaitAsync();
                if (timer != null) timer.Change(Timeout.Infinite, Timeout.Infinite);

                form.Hide();
                browser.Hide();

                return result;
            }
        }

        private void Log(string eventName, Uri url)
        {
            Log(eventName, url.OriginalString);
        }

        private void Log(string eventName, string url)
        {
            _logger.Log(eventName, url);
        }
    }
}