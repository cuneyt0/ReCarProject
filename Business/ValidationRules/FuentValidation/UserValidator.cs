using Core.Entities.Concrete;
using Entities.Conctre;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FuentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        //Kurallar constructor içine yazılır.

        public UserValidator()
        {
            
            //RuleFor(u => u.FirstName).NotEmpty().MaximumLength(3).WithMessage("Alan boş veya 3 karakterden az");
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty().MinimumLength(5);
           
        }

       
    }
}
