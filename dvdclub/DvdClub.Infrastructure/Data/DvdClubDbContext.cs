
using DvdClub.Core.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdClub.Infrastructure.Data {
    public class DvdClubDbContext : IdentityDbContext<ExtendedUser> {
        public  DbSet<Movie> Movies { get; set; }//-virtual?
        public  DbSet<Rental> Rentals { get; set; }
        public  DbSet<Copy> Copies { get; set; }

        //public DbSet<UserLogin> UserLogins { get; set; }
        //public DbSet<UserClaim> UserClaims { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
        
        //// ... your custom DbSets
        //public DbSet<RoleOperation> RoleOperations { get; set; }
        public DvdClubDbContext() : base("name=DvdClubDbContext") {
            Database.SetInitializer<DvdClubDbContext>(null);// Remove default initializer
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }
        public static DvdClubDbContext Create() {
            return new DvdClubDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            var krathsh = modelBuilder.Entity<Rental>();

            krathsh.HasKey(x => x.Id);

            var user = modelBuilder.Entity<ExtendedUser>();
            user.Property(x => x.Id).IsRequired().HasMaxLength(256)
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("FullNameIndex")));
            user.HasMany(x => x.Rentals).WithRequired().HasForeignKey(x => x.UserId);
            /**/

        }/*when I scafold a view these get created*/

        //public System.Data.Entity.DbSet<DvdClub.Web.Areas.Movies.Model.MoviesCreateBindingModel> MoviesCreateBindingModels { get; set; }

        //public System.Data.Entity.DbSet<DvdClub.Web.Areas.Movies.Model.MoviesEditBindingModel> MoviesEditBindingModels { get; set; }

        //public System.Data.Entity.DbSet<DvdClub.Web.Areas.Movies.Model.MoviesEditBindingModel> MoviesEditBindingModels { get; set; }

        //public System.Data.Entity.DbSet<DvdClub.Web.Areas.Rentals.Models.RentalsCreateBindingModel> RentalsCreateBindingModels { get; set; }

        //public System.Data.Entity.DbSet<DvdClub.Web.Areas.Rentals.Models.RentalsCreateBindingModel> RentalsCreateBindingModels { get; set; }

        //public System.Data.Entity.DbSet<DvdClub.Core.Entities.ExtendedUser> ExtendedUsers { get; set; }

        //public System.Data.Entity.DbSet<DvdClub.Web.Models.ExtendedUser> ExtendedUsers { get; set; }//this was causing it
    }
}