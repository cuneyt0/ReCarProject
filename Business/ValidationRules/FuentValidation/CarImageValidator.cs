using Entities.Conctre;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FuentValidation
{
    public class CarImageValidator: AbstractValidator<CarImage>
    {

        public CarImageValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0).WithMessage("Id sıfırdan büyük bir deger olmalı");
            RuleFor(c=>c.CarId).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0).WithMessage("CarId sıfırdan büyük bir deger olmalı");
            RuleFor(c => c.ImagePath).NotEmpty().WithMessage("Boş geçilemez");
           
        }

     
    }
}
