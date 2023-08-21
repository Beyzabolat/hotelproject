using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Mapping
{
    public class autoMapperConfig : Profile
    {
        public autoMapperConfig()
        { 
        CreateMap <RoomAddDto, Room>();
        CreateMap<Room, RoomAddDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();


        }
         
    }
}
