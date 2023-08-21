using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace DvdClub.Core.Entities {
    public class ExtendedUser : IdentityUser {
        //[Required]
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; }
        public ICollection<Rental> Rentals { get; set; }

        /*Additional Config For Identity*/
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ExtendedUser> manager) {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}