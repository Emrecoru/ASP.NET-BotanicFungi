using Cantek.ArgeProjectNTier.Common;
using Cantek.ArgeProjectNTier.Dtos;
using Cantek.ArgeProjectNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.Interfaces
{
    public interface IRoomService : IService<RoomCreateDto, RoomUpdateDto, RoomListDto, Room>
    {
        Task<IResponse<List<RoomListDto>>> GetActivesAsync();
        Task<IResponse<List<RoomListDto>>> GetAllAsync();
    }
}
