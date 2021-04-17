using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardTypeValidator : AbstractValidator<CreditCardType>
    {
        public CreditCardTypeValidator()
        {
            RuleFor(t => t.TypeName).NotEmpty();
        }
    }
}