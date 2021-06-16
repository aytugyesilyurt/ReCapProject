using Entities.Concrete.Persons;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).MinimumLength(2).WithMessage("Şirket adı en az 2 karakter uzunluğunda olmalıdır.(Şirket yoksa boş bırakabilirsiniz.)");
        }
    }
}
