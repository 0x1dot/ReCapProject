using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class FuelValidator : AbstractValidator<Fuel>
    {
        public FuelValidator()
        {
            RuleFor(c => c.FuelName).NotEmpty();
            RuleFor(c => c.FuelName).MinimumLength(2);
        }
    }
}
