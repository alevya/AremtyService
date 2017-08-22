using Owin;
using WebApp.Models;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using WebApp.Models.Identity;

[assembly:OwinStartup(typeof(WebApp.StartUp))]
namespace WebApp
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<AppIdenityDbContext>(AppIdenityDbContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}