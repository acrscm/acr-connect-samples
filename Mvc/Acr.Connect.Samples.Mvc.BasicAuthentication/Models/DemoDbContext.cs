using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Models
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("DefaultConnection")
        {
        }

        public static DemoDbContext Create()
        {
            return new DemoDbContext();
        }

        public virtual IDbSet<DemoUser> Users { get; set; }
        public virtual IDbSet<IdentityUserRole> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");

            var users = modelBuilder.Entity<DemoUser>()
                .ToTable("Users");

            users.HasMany(u => u.Roles)
                .WithRequired()
                .HasForeignKey(ur => ur.UserId);

            users.HasMany(u => u.Logins)
                .WithRequired()
                .HasForeignKey(ul => ul.UserId);

            users.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<IdentityUserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId })
                .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserLogin>()
                .HasKey(ul => new { ul.UserId, ul.LoginProvider, ul.ProviderKey })
                .ToTable("UserLogins");

            var roles = modelBuilder.Entity<DemoRole>()
                .HasKey(r => r.Id)
                .ToTable("Roles");
            roles.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}