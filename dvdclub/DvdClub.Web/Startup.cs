using DvdClub.Web.Controllers;
using DvdClub.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
[assembly:OwinStartupAttribute(typeof(DvdClub.Web.Startup))]
namespace DvdClub.Web {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            //const string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Database=dvdclub49;trusted_connection=yes;Integrated Security=SSPI";

            //app.CreatePerOwinContext(() => new IdentityDbContext(connectionString));
            //app.CreatePerOwinContext<UserStore<IdentityUser>>((opt, cont) =>
            //    new UserStore<IdentityUser>(cont.Get<IdentityDbContext>()));
            //app.CreatePerOwinContext<UserManager<IdentityUser>>((opt, cont) =>
            //    new UserManager<IdentityUser>(cont.Get<UserStore<IdentityUser>>()));
            ///*log in*/
            //app.CreatePerOwinContext<SignInManager<IdentityUser, string>>((opt, cont) =>
            //        new SignInManager<IdentityUser, string>(cont.Get<UserManager<IdentityUser>>(), cont.Authentication));
            ///**/
            ////app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);
            ///*assign user a cookie to stay authenticated*/
            //app.UseCookieAuthentication(new CookieAuthenticationOptions {
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie
            //});


            //var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();




        }

    }
   
}
