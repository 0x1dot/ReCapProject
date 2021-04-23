using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty();
            //RuleFor(c=>c.CardId).GreaterThan(0);
           // RuleFor(c => c.DailyPrice).NotEmpty()
            //    .GreaterThan(0)
            //    .GreaterThanOrEqualTo(10).When(c => c.BrandId == 1);
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }
    }
}
