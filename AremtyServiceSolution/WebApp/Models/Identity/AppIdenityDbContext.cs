using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApp.Models.Aremty;

namespace WebApp.Models.Identity
{
    public class AppIdenityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdenityDbContext() : base("AremtyDb")
        {
            
        }

        public static AppIdenityDbContext Create()
        {
            return new AremtyContextDb();
            //return new AppIdenityDbContext();
        }
    }
}