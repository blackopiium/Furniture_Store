using FluentValidation;
using Furniture_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Furniture_Store.Business.Validators
{
    public class OrderDTOValidator : AbstractValidator<OrderDTO>
    {
        public OrderDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Country)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.City)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.Street)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.Apartment)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.ClientId)
                .NotEmpty();
        }
    }
}
