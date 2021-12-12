using Core.Utilitiess.Results;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersServices
    {
        IResult Add(Users users);
        IResult Delete(Users users);
        IDataResult<List<Users>> GetAll();

        IResult Update(Users users);
        IDataResult<Users> GetUsersById(int id);
    }
}
