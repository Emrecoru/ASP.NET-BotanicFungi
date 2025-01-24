using AutoMapper;
using Cantek.ArgeProjectNTier.Dtos;
using Cantek.ArgeProjectNTier.UI.Models;

namespace Cantek.ArgeProjectNTier.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>();

        }
    }
}
