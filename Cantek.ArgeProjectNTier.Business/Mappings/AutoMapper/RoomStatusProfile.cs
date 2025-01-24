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
    public class RoomStatusProfile : Profile
    {
        public RoomStatusProfile()
        {
            CreateMap<RoomStatus, RoomStatusCreateDto>().ReverseMap();
            CreateMap<RoomStatus, RoomUpdateDto>().ReverseMap();
            CreateMap<RoomStatus, RoomStatusListDto>().ReverseMap();
            CreateMap<RoomStatusCreateDto, RoomStatusUpdateDto>().ReverseMap();
        }
    }
}
