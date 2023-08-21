using AutoMapper;
using DvdClub.Core.Entities;
using DvdClub.Web.Areas.Rentals.Models;
using DvdClub.Web.Areas.Users.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static AutoMapper.Internal.ExpressionFactory;

namespace DvdClub.Web.Mappings.Profile {
    public class RentalsProfile : AutoMapper.Profile {
        public RentalsProfile() {
            CreateMap<RentalsCreateBindingModel, Rental>(MemberList.None)
                .ReverseMap();
                //.ForMember(dest => dest.Copy.Movie.Title, X => X.MapFrom(source => source.Email))
            //CreateMap<RentalsViewModel, Rental>().ReverseMap();//(MemberList.None)


            //CreateMap<RentalsCreateBindingModel, Rental>()
            //    .ReverseMap();


            //CreateMap<RentalsCreateBindingModel, Rental>(MemberList.None)
            //    .ForMember(dest => dest.Comments, x => x.MapFrom(source => source.Comments))
            //    .ForMember(dest => dest.User.Email, x => x.MapFrom(source => source.Email))
            //    .ForMember(dest => dest.Copy.Movie.Title, x => x.MapFrom(source => source.MovieTitle))
            //    .ReverseMap();

        }
    }
}