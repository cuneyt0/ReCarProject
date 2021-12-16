using Entities.Conctre;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FuentValidation
{
    public class RentalValidator: AbstractValidator<Rentals>
    {
        //Kurallar constructor içine yazılır.
        public RentalValidator()
        {
             RuleFor(r=>r.Id).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(r=>r.CustomerId).NotEmpty().WithMessage("Boş geçilemez").GreaterThan(0);
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Boş geçilemez").GreaterThanOrEqualTo(1);
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Boş geçilemez").GreaterThanOrEqualTo(DateTime.Now);
           
        }

        
    }
}
