using AutoMapper;
using Hotel.Apı.Model.Derived;
using Hotel.Apı.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Services.Infrastructure
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<RoomEntity, Room>()
                .ForMember(dest => dest.Rate, opt =>
                   opt.MapFrom(scr => scr.Rate / 100));

            CreateMap<UserEntity, UserInfo>()
                .ForMember(desc => desc.FullName, opt =>
                    opt.MapFrom(scr => string.Concat(scr.Name, scr.SurName)));
        }
    }
}