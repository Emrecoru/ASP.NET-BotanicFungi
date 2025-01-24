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
    public class ParameterProfile : Profile
    {
        public ParameterProfile()
        {
            CreateMap<Parameter, ParameterListDto>().ReverseMap();
            CreateMap<Parameter, ParameterCreateDto>().ReverseMap();
            CreateMap<Parameter, ParameterUpdateDto>().ReverseMap();

        }
    }
}
