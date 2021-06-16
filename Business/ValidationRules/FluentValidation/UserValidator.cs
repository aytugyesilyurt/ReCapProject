using Entities.Concrete.Persons;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("İsim boş bırakılamaz");
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("İsim en az 2 karakter uzunluğunda olmalıdır.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyadı boş bırakılamaz.");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Soyadı en az 2 karakter uzunluğunda olmalıdır.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Email boş bırakılamaz.");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Email adresi geçersiz.Lütfen kontrol ediniz.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifrenizi yazınız.");
            

        }
    }
}
