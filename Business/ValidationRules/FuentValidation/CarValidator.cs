using Entities.Conctre;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FuentValidation
{
    class CarValidator:AbstractValidator<Cars>
    {
        //Kurallar constructor içine yazılır.

        public CarValidator()
        {
            RuleFor(c=>c.Id).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(c=>c.BrandId).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(c=>c.ColorId).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(c=>c.DailyPrice).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(c=>c.Description).NotEmpty().WithMessage("Boş geçilemez").MinimumLength(3).MaximumLength(50);
        }
    }
}
