using IdentityModel.Client;
using Microsoft.AspNet.Identity;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Notifications;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;

[assembly: OwinStartup(typeof(Acr.Connect.Samples.AspNetMvc.Startup))]

namespace Acr.Connect.Samples.AspNetMvc
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });

            var oidcOptions = new OpenIdConnectAuthenticationOptions()
            {
                SignInAsAuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                AuthenticationType = "acrid",
                Authority = AppSettings.Authority,
                ClientId = AppSettings.ClientId,
                ClientSecret = AppSettings.ClientSecret,
                ResponseType = "code",
                RedirectUri = AppSettings.RedirectUrl,
                Scope = "openid email profile",
                PostLogoutRedirectUri = AppSettings.PostLogoutRedirectUri
            };

            oidcOptions.TokenValidationParameters.SaveSigninToken = true;

            oidcOptions.Notifications = new OpenIdConnectAuthenticationNotifications
            {
                MessageReceived = MessageReceived,
                SecurityTokenValidated = SecurityTokenValidated,
                RedirectToIdentityProvider = RedirectToIdentityProvider
            };

            app.UseOpenIdConnectAuthentication(oidcOptions);
        }

        private Task RedirectToIdentityProvider(RedirectToIdentityProviderNotification<OpenIdConnectMessage, OpenIdConnectAuthenticationOptions> arg)
        {
            if(arg.ProtocolMessage.RequestType == OpenIdConnectRequestType.Logout)
            {
                var identiy = ((ClaimsIdentity)arg.OwinContext.Authentication.User.Identity);
                var idToken = identiy.BootstrapContext as string;

                arg.ProtocolMessage.IdTokenHint = idToken;
            }

            return Task.CompletedTask;
        }

        private async Task MessageReceived(MessageReceivedNotification<OpenIdConnectMessage, OpenIdConnectAuthenticationOptions> arg)
        {
            var httpClient = new HttpClient();
            var config = await arg.Options.ConfigurationManager.GetConfigurationAsync(CancellationToken.None);
            var request = new AuthorizationCodeTokenRequest
            {
                Code = arg.ProtocolMessage.Code,
                ClientId = arg.Options.ClientId,
                ClientSecret = arg.Options.ClientSecret,
                RedirectUri = arg.Options.RedirectUri,
                Address = config.TokenEndpoint
            };
            var response = await httpClient.RequestAuthorizationCodeTokenAsync(request);

            arg.ProtocolMessage.IdToken = response.IdentityToken;
            arg.ProtocolMessage.AccessToken = response.AccessToken;
            arg.ProtocolMessage.Code = null;
        }

        private async Task SecurityTokenValidated(SecurityTokenValidatedNotification<OpenIdConnectMessage, OpenIdConnectAuthenticationOptions> arg)
        {
            var httpClient = new HttpClient();
            var config = await arg.Options.ConfigurationManager.GetConfigurationAsync(CancellationToken.None);
            var request = new UserInfoRequest
            {
                Address = config.UserInfoEndpoint,
                Token = arg.ProtocolMessage.AccessToken
            };
            var response = await httpClient.GetUserInfoAsync(request);

            arg.AuthenticationTicket.Identity.AddClaim(response.Claims.First(c => c.Type == "email_verified"));

            var nameClaim = response.Claims.First(c => c.Type == "name");

            arg.AuthenticationTicket.Identity.AddClaim(new Claim(ClaimTypes.Name, nameClaim.Value));
        }
    }
}
