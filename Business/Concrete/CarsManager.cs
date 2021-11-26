using Business.Abstract;
using DataAccess.Abstract;
using Entities.Conctre;
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
            if (cars.DailyPrice > 800)
            {
                _carsDal.Add(cars);
            }
            else
            {
                Console.WriteLine("The daily price cannot be lower than 800 units");
            }
        }

        public void Delete(Cars car)
        {
            _carsDal.Delete(car);
           
        }

        public List<Cars> GetAll()
        {
            return _carsDal.GetAll();
        }

        public List<Cars> GetById(int Id)
        {
           if(Id<0 && Id > 10000)
            {
                
                return null;
               
            }
            else
            {
                return _carsDal.GetById(Id);
            }
        }

      
        }
    }

