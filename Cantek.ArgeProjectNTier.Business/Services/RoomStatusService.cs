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
    internal class RoomStatusService : Service<RoomStatusCreateDto, RoomStatusUpdateDto, RoomStatusListDto,
        RoomStatus>, IRoomStatusService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public RoomStatusService(IMapper mapper, IValidator<RoomStatusCreateDto> createDtoValidator,
            IValidator<RoomStatusUpdateDto> updateDtoValidator, IUow uow)
            : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IResponse<List<RoomStatusListDto>>> GetActivesAsync()
        {
            var data = await _uow.GetRepository<RoomStatus>().GetAllAsync();
            var dto = _mapper.Map<List<RoomStatusListDto>>(data);
            return new Response<List<RoomStatusListDto>>(ResponseType.Success, dto);
        }

    }
}
