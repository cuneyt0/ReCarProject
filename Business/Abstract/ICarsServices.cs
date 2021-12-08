using Entities.Conctre;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarsServices
    {
       
        List<Cars> GetCarsByBrandId(int id);

        List<Cars> GetCarsByColorId(int id);

        public void Add(Cars cars);


        public void Delete(Cars car);

        List<CarDetailsDto> GetCarsDetails();
       




    }
}
