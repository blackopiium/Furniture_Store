using FluentValidation;
using Furniture_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Business.Validators
{
   public class ItemDTOValidator : AbstractValidator<ItemDTO>
    {
        public ItemDTOValidator()
        {
            RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty()
            .GreaterThan(0);
            RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(30);
            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);


        }
    }
}
