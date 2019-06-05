using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Mvc;

namespace Acr.Connect.Samples.AspNetMvc.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationManager AuthManager => HttpContext.GetOwinContext().Authentication;

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("Index", "Home") };
            AuthManager.Challenge(properties, "acrid");

            return new HttpUnauthorizedResult();
        }

        [HttpPost]
        //[AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Logoff()
        {
            AuthManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie, "acrid");
            return RedirectToAction("Index", "Home");
        }
    }
}