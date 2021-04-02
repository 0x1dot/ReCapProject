using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email)
                .NotEmpty()
                .MinimumLength(10)
                .EmailAddress();
            RuleFor(u => u.Password).NotEmpty();
            
        }
    }
}
