using FluentValidation;
using Furniture_Store.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.WEB.Validators
{
    public class RegisterValidator :AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty();

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(x => x.PasswordConfirm)
                .NotEmpty()
                .Equal(x => x.Password)
                .WithMessage("Passwords dont match");
        }
    }
}
