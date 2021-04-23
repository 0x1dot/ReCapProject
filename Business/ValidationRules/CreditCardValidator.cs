using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator : AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(t => t.CardNumber).NotEmpty();
            RuleFor(t => t.CardTypeId).NotEmpty();
            RuleFor(t => t.Cvv).NotNull();
            RuleFor(t => t.FirstName).NotEmpty();
            RuleFor(t => t.LastName).NotEmpty();
            RuleFor(t => t.ExpirationMonth).NotEmpty();
            RuleFor(t => t.ExpirationYear).NotEmpty();
        }
    }
}