using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Araç adı boş bırakılamaz.");
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araç adı en az 2 karakter uzunluğunda olmalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Araç ücreti boş bırakılamaz.");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Araç ücreti 0 olamaz.");
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage("Araç yılı boş bırakılamaz.");
            RuleFor(c => c.ModelYear).InclusiveBetween(1672, DateTime.Now.Year + 1);
            RuleFor(c => c.Description).NotEmpty().WithMessage("Lütfen araç hakkında açıklama yazınız");
        }
    }
}
