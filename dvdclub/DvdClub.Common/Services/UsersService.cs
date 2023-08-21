using DvdClub.Core.Entities;
using DvdClub.Core.Interfaces;
using DvdClub.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdClub.Common.Services {
    public class UsersService : IUsersService {
        private /*readonly*/ DvdClubDbContext db;

        public UsersService(DvdClubDbContext db) {
            this.db = db;
        }

        public IEnumerable<ExtendedUser> GetAll() {
            return db.Users;
        }
    }
}
