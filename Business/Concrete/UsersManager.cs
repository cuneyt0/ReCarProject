using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FuentValidation;
using Core.CrossCuttingCorcerns.Validation;
using Core.Utilitiess.Results;
using DataAccess.Abstract;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersServices
    {
        IUsersDal _usersdal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersdal = usersDal;
        }
        public IResult Add(Users users)
        {
            
            ValidationTool.Validate(new UserValidator(), users);
                _usersdal.Add(users);
                return new SuccessResult(Messages.UserAdd);
            
        }

        public IResult Delete(Users users)
        {
            if (users.Id<=0)
            {
                return new ErrorResult(users.Id.ToString()+" "+Messages.UserAddErrorMessage);
            }
            else
            {
                _usersdal.Delete(users);
                return new SuccessResult(Messages.UserDelete);
            }
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersdal.GetAll());
        }

        public IDataResult<Users> GetUsersById(int id)
        {
            if (id <= 0 )
            {
                return new ErrorDataResult<Users>(Messages.UserFindErrorMessage);
            }
            return new SuccessDataResult<Users>(_usersdal.Get(u => u.Id == id));
        }

        public IResult Update(Users users)
        {
            if (users.Id <= 0)
            {
                return new ErrorDataResult<Users>(Messages.UserUpdateErrorMessage);
            }
            _usersdal.Update(users);
            return new SuccessDataResult<Users>(Messages.UserUpdate);
        }
    }
}
