using System.Configuration;
using System.Runtime.CompilerServices;

namespace Acr.Connect.Samples.AspNetMvc
{
    public static class AppSettings
    {
        public static string ClientId { get => Get(); }
        public static string ClientSecret { get => Get(); }
        public static string Authority { get => Get(); }
        public static string RedirectUrl { get => Get(); }
        public static string PostLogoutRedirectUri { get => Get(); }

        private static string Get([CallerMemberName] string name=null)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}