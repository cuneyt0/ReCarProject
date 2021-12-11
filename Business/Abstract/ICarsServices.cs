using Core.Utilitiess.Results;
using Entities.Conctre;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarsServices
    {
       
        IDataResult<List<Cars>> GetCarsByBrandId(int id);
        //List<Cars> 

        IDataResult<List<Cars>> GetCarsByColorId(int id);

        IResult Add(Cars cars);


        IResult Delete(Cars car);

        IDataResult<List<CarDetailsDto>> GetCarsDetails();
       




    }
}
