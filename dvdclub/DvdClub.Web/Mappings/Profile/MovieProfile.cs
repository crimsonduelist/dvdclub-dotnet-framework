using AutoMapper;
using DvdClub.Core.Entities;
using DvdClub.Web.Areas.Movies.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdClub.Web.Mappings.Profile {
    public class MovieProfile : AutoMapper.Profile {
        public MovieProfile() {
            //CreateMap<MovieIndexViewModel, Movie>(MemberList.None).ReverseMap();
            CreateMap<MoviesCreateBindingModel, Movie>(MemberList.None).ReverseMap();
            //CreateMap<MoviesEditBindingModel, Movie>(MemberList.None).ReverseMap();
        }
    }
}