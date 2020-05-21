using FluentValidation;
using Furniture_Store.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Furniture_Store.WEB.Validators
{
    public class ItemValidator : AbstractValidator<ItemViewModel>
    {
        public ItemValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(40);
            RuleFor(x => x.Price)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}
