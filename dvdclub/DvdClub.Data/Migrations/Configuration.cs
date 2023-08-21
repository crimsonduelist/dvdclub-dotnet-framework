//namespace DvdClub.Data.Migrations {
//    using DvdClub.Data.Services;
//    using DvdClub.Web.Models;
//    using Microsoft.AspNet.Identity;
//    using Microsoft.AspNet.Identity.EntityFramework;
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<DvdClub.Data.Services.DvdClubDbContext> {
//        public Configuration() {
//            AutomaticMigrationsEnabled = false;
//        }

//        protected override void Seed(DvdClub.Data.Services.DvdClubDbContext context) {
//            //  This method will be called after migrating to the latest version.
//            //var user = new ExtendedUser {
//            //UserName = model.Email,
//            //Email = model.Email,
//            //FirstName = model.FirstName, LastName = model.LastName };

//            var manager = new UserManager<ExtendedUser>(new UserStore<ExtendedUser>(new DvdClubDbContext()));
//            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new DvdClubDbContext()));
//            /*handle this better? if(findbyUser not exists){insert} else{update}*/
//            /*create the roles if not exist*/
//            if( roleManager.Roles.Count() == 0 ) {
//                roleManager.Create(new IdentityRole { Name = "admin" });
//                roleManager.Create(new IdentityRole { Name = "user" });
//            }
//            /*create the admin if not exist*/
//            var adminUser = manager.FindByName("crimson@crimson.com");
//            if( adminUser == null ) {
//                var user = new ExtendedUser() {
//                    UserName = "crimson@crimson.com",
//                    Email = "crimson@crimson.com",
//                    EmailConfirmed = true,
//                    FirstName = "crimson",
//                    LastName = "night",
//                };
//                manager.CreateAsync(user, "pass1234");
//                manager.AddToRole(adminUser.Id, "admin");
//            }

            

//            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//            //  to avoid creating duplicate seed data. E.g.
//            //
//            //    context.People.AddOrUpdate(
//            //      p => p.FullName,
//            //      new Person { FullName = "Andrew Peters" },
//            //      new Person { FullName = "Brice Lambson" },
//            //      new Person { FullName = "Rowan Miller" }
//            //    );
//            //
//        }
//    }
//}
