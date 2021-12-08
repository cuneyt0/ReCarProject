using Business.Abstract;
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

        public void Add(Cars cars)
        {
            if (cars.Description.Length> 2 && cars.DailyPrice > 0)
            {
                _carsDal.Add(cars);
            }
          
            else
            {
                Console.WriteLine("The description lenght cannot be lower than 2 letter or Daily Price must be greater than 0");
            }
        }

        public void Delete(Cars car)
        {
            _carsDal.Delete(car);
           
        }

       

        public List<Cars> GetCarsByBrandId(int id)
        {
            return  _carsDal.GetAll(c => c.BrandId == id);
        }

        public List<Cars> GetCarsByColorId(int id)
        {
            return _carsDal.GetAll(c => c.ColorId == id);
        }

        public List<CarDetailsDto> GetCarsDetails()
        {
            return _carsDal.GetCarsDetails();
        }
    }
    }

