using DvdClub.Core.Entities;
using DvdClub.Core.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DvdClub.Core.Interfaces {
    public interface IRentalsService {
        IEnumerable<Rental> GetAll();
        IEnumerable<Rental> GetAllRentalsByUserId(string id);
        IEnumerable<Rental> GetAllActive();
        //IEnumerable<Rental> GetRentalsByUser(string Email);
        Rental Get(int id);
        void Add(Rental krathsh);
        void Update(Rental krathsh);
        bool Return(int id);
        Copy GetCopyByMovieId(int id);
        IEnumerable<ExtendedUser> GetEmails();
        IEnumerable<SelectListItem> GetEmailsAsSelectListItems();
        IEnumerable<Movie> GetMovieTitles();
        string GetUserIds(string userIdToBe);
        int GetAvailabilityByMovieId(int movieId);
        string GetUserIdByName(string UserName);
    }
}
