using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class GearValidator : AbstractValidator<Gear>
    {
        public GearValidator()
        {
            RuleFor(c => c.GearName).NotEmpty();
            RuleFor(c => c.GearName).MinimumLength(2);
        }
    }
}
