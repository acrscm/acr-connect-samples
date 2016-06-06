using System;
using System.Threading.Tasks;
using Acr.Connect.Samples.Mvc.BasicAuthentication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Auth
{
public class DemoSignInManager: IDisposable
    {
        private readonly DemoUserManager _userManager;
        private readonly IAuthenticationManager _authenticationManager;

        public DemoSignInManager(DemoUserManager userManager, IAuthenticationManager authenticationManager)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
        }

        public static DemoSignInManager Create(IdentityFactoryOptions<DemoSignInManager> options, IOwinContext context)
        {
            return new DemoSignInManager(context.GetUserManager<DemoUserManager>(), context.Authentication);
        }

        public async Task<SignInStatus> ExternalSignInAsync(ExternalLoginInfo loginInfo, bool isPersistent)
        {
            var user = await _userManager.FindAsync(loginInfo.Login);
            if (user == null)
            {
                return SignInStatus.Failure;
            }
            await SignInAsync(user, isPersistent).ConfigureAwait(false);
            return SignInStatus.Success;
        }

        public async Task SignInAsync(DemoUser user, bool isPersistent)
        {
            var userIdentity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            _authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            _authenticationManager.SignIn(new AuthenticationProperties { IsPersistent = isPersistent }, userIdentity);
        }

        public void Dispose()
        { }
    }
}