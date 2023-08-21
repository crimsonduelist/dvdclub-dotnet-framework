using AutoMapper;
using DvdClub.Core.Entities;
using DvdClub.Web.Areas.Users.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static AutoMapper.Internal.ExpressionFactory;

namespace DvdClub.Web.Mappings.Profile {
    public class MemberProfile : AutoMapper.Profile {
        public MemberProfile() {
            CreateMap<MembersIndexViewModel, IEnumerable<Member>>(MemberList.None).ReverseMap();
        }
    }
}