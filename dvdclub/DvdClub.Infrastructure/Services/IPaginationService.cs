using DvdClub.Core.Entities;
using DvdClub.Core.Enumeration;
using DvdClub.Infrastructure.Models;
using DvdClub.Infrastructure.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdClub.Infrastructure.Services {
    public interface IPaginationService {
       /* Task<*/PaginationModel<Movie>/*> */GetPaginatedMoviesAsync(PaginationDto pagination, string genre, string searchString);
    }
}
