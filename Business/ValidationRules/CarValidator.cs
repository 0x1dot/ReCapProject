using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty()
                 .MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty()
                .GreaterThan(0)
                .GreaterThanOrEqualTo(10).When(c => c.BrandId == 1);
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
