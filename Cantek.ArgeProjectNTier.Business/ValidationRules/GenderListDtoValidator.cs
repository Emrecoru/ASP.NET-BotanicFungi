﻿using Cantek.ArgeProjectNTier.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.ValidationRules
{
    public class GenderListDtoValidator : AbstractValidator<GenderListDto>
    {
        public GenderListDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.GenderType).NotEmpty();
        }
    }
}
