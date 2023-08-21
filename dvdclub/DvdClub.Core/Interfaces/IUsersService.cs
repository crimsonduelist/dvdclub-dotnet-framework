using DvdClub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdClub.Core.Interfaces {
    public interface IUsersService {
        IEnumerable<ExtendedUser> GetAll();
    }
}
