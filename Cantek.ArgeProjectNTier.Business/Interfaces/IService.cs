
using Cantek.ArgeProjectNTier.Common;
using Cantek.ArgeProjectNTier.Dtos;
using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using Cantek.ArgeProjectNTier.Entities;

namespace Cantek.ArgeProjectNTier.Business.Interfaces
{
    public interface IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);

        Task<IResponse<IDto>> GetById<IDto>(int id);

        Task<IResponse> RemoveAsync(int id);

        Task<IResponse<List<ListDto>>> GetAllAsync();
    }
}
