using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Acr.Connect.Samples.Mvc.BasicAuthentication.Startup))]
namespace Acr.Connect.Samples.Mvc.BasicAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
