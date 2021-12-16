using Entities.Conctre;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FuentValidation
{
    public class CustomerValidator: AbstractValidator<Customers>
    {
        //Kurallar constructor içine yazılır.
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(c => c.UserId).NotEmpty().WithMessage("Boş geçilemez").WithMessage("User Id Boş");
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Boş geçilemez").MinimumLength(2).WithMessage("Minimum deger iki den büyük olmalı");
        }
    }
}
