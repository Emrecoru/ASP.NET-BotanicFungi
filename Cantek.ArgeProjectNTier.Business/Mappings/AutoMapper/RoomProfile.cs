using AutoMapper;
using Cantek.ArgeProjectNTier.Dtos;
using Cantek.ArgeProjectNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.Mappings.AutoMapper
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<RoomCreateDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
            CreateMap<RoomListDto, Room>().ReverseMap();
            CreateMap<RoomCreateDto, RoomUpdateDto>().ReverseMap();
        }
    }
}
