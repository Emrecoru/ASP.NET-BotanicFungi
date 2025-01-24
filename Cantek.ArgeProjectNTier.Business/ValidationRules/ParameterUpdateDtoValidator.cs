using Cantek.ArgeProjectNTier.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Business.ValidationRules
{
    public class ParameterUpdateDtoValidator : AbstractValidator<ParameterUpdateDto>
    {
        public ParameterUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Type).NotEmpty();
            RuleFor(x => x.Value).NotEmpty()
            .Must(IsValidDecimalPrecision).WithMessage("Value must have a valid decimal precision (7,4)");
        }

        public bool IsValidDecimalPrecision(decimal value)
        {
            // Convert the decimal value to string and split it into integer and fractional parts
            string[] parts = value.ToString().Split('.');

            // Check if the integer part has at most 3 digits and the fractional part has at most 4 digits
            return parts[0].Length <= 3 && (parts.Length == 1 || parts[1].Length <= 4);
        }
    }

}

