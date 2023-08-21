﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdClub.Core.Entities {
    public class Copy {
        
        [Key]
        [Display(Name = "cid")]
        public int Id { get; set; }

        [DefaultValue(true)]
        public bool Availability { get; set; }//bool

        /*configure copies relationship with movies*/
        //[Column("movieId")]
        public int MovieId { get; set; }
        public Movie Movie{ get; set; }
        
        /*configure copies relationship with Rentals*/
        public ICollection<Rental> Rentals { get; set; }

        /*constructor*/
    }
}
