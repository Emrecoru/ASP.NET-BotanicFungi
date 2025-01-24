using AutoMapper;
using Cantek.ArgeProjectNTier.Business.Interfaces;
using Cantek.ArgeProjectNTier.Common;
using Cantek.ArgeProjectNTier.DataAccess.UnitOfWork;
using Cantek.ArgeProjectNTier.Dtos;
using Cantek.ArgeProjectNTier.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.Services
{
    public class RoomService : Service<RoomCreateDto, RoomUpdateDto, RoomListDto, Room>, IRoomService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public RoomService(IMapper mapper, IValidator<RoomCreateDto> createDtoValidator,
            IValidator<RoomUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<RoomListDto>>> GetActivesAsync()
        {
            var data2 = await _uow.GetRepository<RoomStatus>().GetAllAsync();
            var data = await _uow.GetRepository<Room>().GetAllAsync(x => x.RoomStatus.Definition == Common.Enums.RoomStatusDefinition.RUN);

            foreach (var room in data)
            {
                var matchingRoomStatus = data2.FirstOrDefault(rs => rs.Id == room.RoomStatusId);
                if (matchingRoomStatus != null)
                {
                    room.RoomStatus = matchingRoomStatus;
                }
            }
            var dto = _mapper.Map<List<RoomListDto>>(data);
            return new Response<List<RoomListDto>>(ResponseType.Success, dto);
        }

         public async Task<IResponse<List<RoomListDto>>> GetAllAsync()
        {
            var data2 = await _uow.GetRepository<RoomStatus>().GetAllAsync();
            var data = await _uow.GetRepository<Room>().GetAllAsync();

            foreach (var room in data)
            {
                var matchingRoomStatus = data2.FirstOrDefault(rs => rs.Id == room.RoomStatusId);
                if (matchingRoomStatus != null)
                {
                    room.RoomStatus = matchingRoomStatus;
                }
            }
            var dto = _mapper.Map<List<RoomListDto>>(data);
            return new Response<List<RoomListDto>>(ResponseType.Success, dto);
        }
    }
}
