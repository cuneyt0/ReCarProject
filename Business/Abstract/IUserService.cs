using Core.Entities;
using Core.Entities.Concrete;
using Core.Utilitiess.Results;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {


        IResult Add(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();

        IResult Update(User users);
        IDataResult<User> GetUsersById(int id);

        List<OperationClaim> GetClaims(User user);
  
        User GetByMail(string email);
    }
}
