using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FuentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilitiess.Results;
using DataAccess.Abstract;
using Entities.Conctre;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarsManager : ICarsServices
    {
        ICarDal _carsDal;

        public CarsManager(ICarDal carsDal)
        {
            _carsDal = carsDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Cars cars)
        {
           
                _carsDal.Add(cars);
                return new SuccessResult(Messages.CarAdd);
           
        }

        public IResult Delete(Cars car)
        {
            if (car.Id <= 0)
            {
                return new ErrorResult(Messages.CarDeleteErrorMessage);
            }
            else
            {
                _carsDal.Delete(car);
                return new SuccessResult(Messages.CarDelete);


            }

        }

       

        public IDataResult<List<Cars>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carsDal.GetAll(c => c.BrandId == id));

        }

        public IDataResult<List<Cars>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carsDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarsDetails()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.ErrorDTO);

            }
            return new SuccessDataResult<List<CarDetailsDto>>(_carsDal.GetCarsDetails());
          
        }
    }
    }

