using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApp.Models.Identity
{
    public class AppIdenityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdenityDbContext() : base("IdentityDb")
        {
            
        }

        public static AppIdenityDbContext Create()
        {
            return new AppIdenityDbContext();
        }
    }
}