using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApp.Models.Identity
{
    public class AppUser : IdentityUser
    {
        #region Init

        public int Year { get; set; }

        public AppUser()
        {
            
        }

        #endregion
    }
}