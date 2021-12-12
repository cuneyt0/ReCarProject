using Core.Utilitiess.Results;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomersServices
    {
        IResult Add(Customers customer);
        IResult Delete(Customers customer);
        IDataResult<List<Customers>> GetAll();

        IResult Update(Customers customer);
        IDataResult<Customers> GetCustomerById(int id);
    }
}
