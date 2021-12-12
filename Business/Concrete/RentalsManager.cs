using Business.Abstract;
using Business.Constants;
using Core.Utilitiess.Results;
using DataAccess.Abstract;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager: IRentalServices
    {

        IRentalsDal _rentalsDal;
        public RentalsManager(IRentalsDal rentalsdal)
        {
            _rentalsDal = rentalsdal;
        }

        public IResult Add(Rentals rental)
        {
            if (rental.Id <= 0 && rental.CustomerId<=0 && rental.CarId<=0 && rental.ReturnDate!=null)
            {
                return new ErrorResult(Messages.RentalAddErrorMessage);
            }
            else
            {
                _rentalsDal.Add(rental);
                return new SuccessResult(Messages.RentalAdd);
            }
        }

        public IResult Delete(Rentals rental)
        {
            if (rental.ReturnDate != null)
            {
                return new ErrorResult(rental.Id.ToString() + " " + Messages.RentalDeleteErrorMessage);
            }
            else
            {
                _rentalsDal.Delete(rental);
                return new SuccessResult(Messages.RentalDelete);
            }
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll());
        }

        public IDataResult<Rentals> GetRentalById(int id)
        {
            if (id <= 0)
            {
                return new ErrorDataResult<Rentals>(Messages.RentalFindErrorMessage);
            }
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(r => r.Id == id),Messages.RentalFind);
        }

        public IResult Update(Rentals rental)
        {
            if (rental.Id <= 0)
            {
                return new ErrorDataResult<Users>(Messages.RentalUpdateErrorMessage);
            }
            _rentalsDal.Update(rental);
            return new SuccessDataResult<Users>(Messages.RentalUpdate);
        }
    }
}
