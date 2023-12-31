﻿using AutoMapper;
using HotelProject.DTOLayer.DTOs.RoomDTO;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebAPI.Mapping
{
    public class AutoMapperConfig:Profile
    {

        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room,RoomAddDto>();

            CreateMap<UpdateRoomDto,Room>().ReverseMap();

        }
    }
}
