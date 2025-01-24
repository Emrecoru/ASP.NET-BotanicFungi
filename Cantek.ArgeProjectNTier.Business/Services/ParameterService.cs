using AutoMapper;
using Cantek.ArgeProjectNTier.Business.Interfaces;
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
    public class ParameterService : Service<ParameterCreateDto, ParameterUpdateDto, ParameterListDto, Parameter>,
        IParameterService
    {
        public ParameterService(IMapper mapper, IValidator<ParameterCreateDto> createDtoValidator,
            IValidator<ParameterUpdateDto> updateDtoValidator, IUow uow) 
            : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {

        }
    }
}
