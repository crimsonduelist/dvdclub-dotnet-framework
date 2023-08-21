using DvdClub.Core.Entities;
using DvdClub.Core.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdClub.Web.Areas.Movies.Model {
    public class MovieIndexViewModel {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        /*configure copies relationship with movies*/
        public virtual ICollection<Copy> Copy { get; set; }//list --constructor needed

        //could have inputed 2 more fields in here for filtering i.e. searchString, genre
        public MovieIndexViewModel() {
        }
        public MovieIndexViewModel(int id, string title, string description, Genre genre, ICollection<Copy> copies) {
            Id = id;
            Title = title;
            Description = description;
            Genre = genre;
            Copy = copies;
        }
    }


}