using Core.Utilitiess.Results;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalServices
    {
        IResult Add(Rentals rental);
        IResult Delete(Rentals rental);
        IDataResult<List<Rentals>> GetAll();

        IResult Update(Rentals rental);
        IDataResult<Rentals> GetRentalById(int id);
    }
}
