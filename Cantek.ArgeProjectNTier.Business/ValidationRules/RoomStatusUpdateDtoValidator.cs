using Cantek.ArgeProjectNTier.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.ValidationRules
{
    public class RoomStatusUpdateDtoValidator : AbstractValidator<RoomStatusUpdateDto>
    {
        public RoomStatusUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.SquareMeters).NotEmpty();
            RuleFor(x => x.Definition)
            .NotEmpty()
            .Must(IsValidDefinitionValue).WithMessage("Invalid Definition value");
        }

        private bool IsValidDefinitionValue(string definition)
        {
            return definition == "RUN" || definition == "SLEEP" || definition == "END";
        }
    }
}
