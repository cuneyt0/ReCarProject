using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarsServices
    {
        List<Cars> GetAll();

        void Add(Cars cars);

        void Delete(Cars car);

        List<Cars> GetById(int Id);

     
    }
}
