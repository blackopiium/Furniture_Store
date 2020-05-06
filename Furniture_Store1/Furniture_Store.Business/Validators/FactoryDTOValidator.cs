using FluentValidation;
using Furniture_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Business.Validators
{
   public class FactoryDTOValidator : AbstractValidator<FactoryDTO>
    {
        public FactoryDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.Country)
                .MaximumLength(40);
        }
    }
}
