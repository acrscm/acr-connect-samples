using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Acr.Connect.Samples.WebForms.BasicAuthentication.Startup))]
namespace Acr.Connect.Samples.WebForms.BasicAuthentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
