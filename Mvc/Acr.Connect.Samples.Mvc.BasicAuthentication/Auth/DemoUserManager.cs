using Acr.Connect.Samples.Mvc.BasicAuthentication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Auth
{
    public class DemoUserManager : UserManager<DemoUser>
    {
        public DemoUserManager(IUserStore<DemoUser> store)
            : base(store)
        {
        }

        public static DemoUserManager Create(IdentityFactoryOptions<DemoUserManager> options, IOwinContext context)
        {
            return new DemoUserManager(new DemoUserStore(context.Get<DemoDbContext>()));
        }
    }
}