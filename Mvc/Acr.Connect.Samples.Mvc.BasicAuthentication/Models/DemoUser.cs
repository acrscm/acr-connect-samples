using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Models
{
    public class DemoUser : IUser
    {
        public DemoUser(string id)
        {
            Id = id;
            Roles = new List<IdentityUserRole>();
            Logins = new List<IdentityUserLogin>();
        }

        public DemoUser()
            : this(Guid.NewGuid().ToString())
        {

        }

        public string Id { get; private set; }
        public string UserName { get; set; }

        public virtual ICollection<IdentityUserRole> Roles { get; private set; }
        public virtual ICollection<IdentityUserLogin> Logins { get; private set; }
    }
}