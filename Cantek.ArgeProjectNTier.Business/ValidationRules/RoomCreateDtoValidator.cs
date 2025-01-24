using Cantek.ArgeProjectNTier.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.ValidationRules
{
    public class RoomCreateDtoValidator : AbstractValidator<RoomCreateDto>
    {
        public RoomCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.RoomType).NotEmpty();
            //RuleFor(x => x.RoomImgPath).NotEmpty();
            RuleFor(x => x.RoomStatusID).NotEmpty();
        }
    }
}
