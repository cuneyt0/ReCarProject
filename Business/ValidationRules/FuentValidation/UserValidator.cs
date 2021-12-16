using Entities.Conctre;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FuentValidation
{
    public class UserValidator:AbstractValidator<Users>
    {
        //Kurallar constructor içine yazılır.

        public UserValidator()
        {
            RuleFor(u => u.Id).GreaterThan(0).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty().MaximumLength(3).WithMessage("Alan boş veya 3 karakterden az");
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty().MinimumLength(5);
            RuleFor(u => u.Password).NotEmpty().GreaterThan(4);
        }

       
    }
}
