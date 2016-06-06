using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Acr.Connect.Samples.Mvc.BasicAuthentication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Auth
{
    public class DemoUserStore :
            IUserStore<DemoUser>
            , IUserLoginStore<DemoUser, string>
            , IUserRoleStore<DemoUser, string>
    {
        private readonly DemoDbContext _dbContext;

        public DemoUserStore(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose()
        {
        }

        public async Task CreateAsync(DemoUser user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(DemoUser user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(DemoUser user)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<DemoUser> FindByIdAsync(string userId)
        {
            return await _dbContext.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task<DemoUser> FindByNameAsync(string userName)
        {
            return await _dbContext.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
        }

        public async Task AddLoginAsync(DemoUser user, UserLoginInfo login)
        {
            var dbSet = _dbContext.Set<IdentityUserLogin>();
            var instance = new IdentityUserLogin
            {
                UserId = user.Id,
                ProviderKey = login.ProviderKey,
                LoginProvider = login.LoginProvider
            };
            dbSet.Add(instance);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveLoginAsync(DemoUser user, UserLoginInfo login)
        {
            var dbSet = _dbContext.Set<IdentityUserLogin>();
            var userLogin = await dbSet.SingleOrDefaultAsync(l => l.UserId == user.Id && l.ProviderKey == login.ProviderKey && l.LoginProvider == login.LoginProvider);
            dbSet.Remove(userLogin);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<UserLoginInfo>> GetLoginsAsync(DemoUser user)
        {
            var logins =
                from login in _dbContext.Set<IdentityUserLogin>()
                where login.UserId == user.Id
                select login;

            return (await logins.ToListAsync()).Select(l => new UserLoginInfo(l.LoginProvider, l.ProviderKey)).ToList();
        }

        public async Task<DemoUser> FindAsync(UserLoginInfo login)
        {
            var users =
                from user in _dbContext.Users
                join userLogin in _dbContext.Set<IdentityUserLogin>() on user.Id equals userLogin.UserId
                where userLogin.ProviderKey == login.ProviderKey && userLogin.LoginProvider == login.LoginProvider
                select user;

            return await users.SingleOrDefaultAsync();
        }

        public async Task AddToRoleAsync(DemoUser user, string roleName)
        {
            _dbContext.Roles.Add(new IdentityUserRole { UserId = user.Id, RoleId = roleName });
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveFromRoleAsync(DemoUser user, string roleName)
        {
            var role = await _dbContext.Roles.SingleAsync(r => r.UserId == user.Id && r.RoleId == roleName);
            _dbContext.Roles.Remove(role);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<string>> GetRolesAsync(DemoUser user)
        {
            var roles =
                from role in _dbContext.Roles
                where role.UserId == user.Id
                select role.RoleId;

            return await roles.ToListAsync();
        }

        public async Task<bool> IsInRoleAsync(DemoUser user, string roleName)
        {
            var roles =
                from role in _dbContext.Roles
                where role.UserId == user.Id && role.RoleId == roleName
                select role;

            return await roles.AnyAsync();
        }
    }
}