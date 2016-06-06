using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Models
{
    public class IndexViewModel
    {
        public IList<UserLoginInfo> Logins { get; set; }
    }
}