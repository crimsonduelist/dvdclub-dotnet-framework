using DvdClub.Core.Entities;
using DvdClub.Core.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdClub.Core.Interfaces {
    public interface IMoviesService {
        IEnumerable<Movie> GetAll();
        IEnumerable<Movie> GetAllByGenre(Genre genre);
        Movie Get(int id);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        int CalculateCopyAvailableCount(int id);
    }
}
