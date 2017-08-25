using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace WebApp.Models.Identity
{
    public class AppUserManager : UserManager<AppUser>
    {
        #region Init

        public AppUserManager(IUserStore<AppUser> store) : base(store)
        {
            
        }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            AppIdenityDbContext dbContext = context.Get<AppIdenityDbContext>();
            AppUserManager manager = new AppUserManager(new UserStore<AppUser>(dbContext));
            return manager;
        }
        #endregion
    }
}