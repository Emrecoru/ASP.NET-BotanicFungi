using Cantek.ArgeProjectNTier.Dtos;
using Cantek.ArgeProjectNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.Interfaces
{
    public interface IRoomStatusService : IService<RoomStatusCreateDto, RoomStatusUpdateDto, RoomStatusListDto, RoomStatus>
    {
    }
}
