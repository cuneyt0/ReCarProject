using DataAccess.Abstract;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Cars>
           {
               new Cars{Id=1,BrandId=1,ColorId=1,DailyPrice=8000,Description="Sıfır Audi A5",ModelYear=2020},
               new Cars{Id=2,BrandId=2,ColorId=3,DailyPrice=2000,Description="Az kullanılmış Renault",ModelYear=2013},
               new Cars{Id=3,BrandId=2,ColorId=1,DailyPrice=4500,Description="Az kullanılmış BWM",ModelYear=2009},
               new Cars{Id=4,BrandId=3,ColorId=2,DailyPrice=9600,Description="az kullanılmış Cadillac",ModelYear=2001},
           };
        }

        public void Add(Cars cars)
        {
           _cars.Add(cars);
        }

        public void Delete(Cars cars)
        {
            Cars carToDelete = _cars.SingleOrDefault(c => c.Id == cars.Id);

            _cars.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Cars cars)
        {

              Cars carToUpdate = _cars.SingleOrDefault(c => c.Id == cars.Id);

             carToUpdate.BrandId = cars.BrandId;
             carToUpdate.ColorId = cars.ColorId;
             carToUpdate.DailyPrice = cars.DailyPrice;
             carToUpdate.Description = cars.Description;
             carToUpdate.ModelYear = cars.ModelYear;
        }
    }
}
