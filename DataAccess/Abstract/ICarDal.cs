using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Cars> GetById(int Id);
        List<Cars> GetAll();
        void Add(Cars cars);

        void Delete(Cars cars);

        void Update(Cars cars);


    }
}
