
using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FuentValidation;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Validation;
using Core.Entities;
using Core.Entities.Concrete;
using Core.Utilitiess.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Add(User user)
        {

            // ValidationTool.Validate(new UserValidator(), users);
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdd);

        }

        public IResult Delete(User user)
        {
            if (user.Id <= 0)
            {
                return new ErrorResult(user.Id.ToString() + " " + Messages.UserAddErrorMessage);
            }
            else
            {
                _userDal.Delete(user);
                return new SuccessResult(Messages.UserDelete);
            }
        }

        [CacheAspect]
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }
        [CacheAspect]
        public IDataResult<User> GetUsersById(int id)
        {
            if (id <= 0)
            {
                return new ErrorDataResult<User>(Messages.UserFindErrorMessage);
            }
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        [CacheRemoveAspect("IUserService.Get")]
        public IResult Update(User user)
        {
            if (user.Id <= 0)
            {
                return new ErrorDataResult<User>(Messages.UserUpdateErrorMessage);
            }
            _userDal.Update(user);
            return new SuccessDataResult<User>(Messages.UserUpdate);
        }



        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

 

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IResult AddTransactionalTest(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}


 