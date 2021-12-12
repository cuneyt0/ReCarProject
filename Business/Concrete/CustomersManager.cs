using Business.Abstract;
using Business.Constants;
using Core.Utilitiess.Results;
using DataAccess.Abstract;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersServices
    {
        ICustomerDal _customerDal;
        public CustomersManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customers customer)
        {
            if (customer.CustomerId<=0)
            {
                return new ErrorResult(Messages.CustomerAddErrorMessage);
            }
            else
            {
                _customerDal.Add(customer);
                return new SuccessResult(Messages.UserAdd);
            }
        }

        public IResult Delete(Customers customer)
        {
            if (customer.CustomerId <= 0)
            {
                return new ErrorResult(customer.CustomerId.ToString() + " " + Messages.CustomerDeleteErrorMessage);
            }
            else
            {
                _customerDal.Delete(customer);
                return new SuccessResult(Messages.CustomerDelete);
            }
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll());
        }

        public IDataResult<Customers> GetCustomerById(int id)
        {
            if (id <= 0)
            {
                return new ErrorDataResult<Customers>(Messages.CustomerFindErrorMessage);
            }
            return new SuccessDataResult<Customers>(_customerDal.Get(u => u.CustomerId == id));
        }

        public IResult Update(Customers customer)
        {
            if (customer.CustomerId <= 0)
            {
                return new ErrorDataResult<Customers>(Messages.CustomerUpdateErrorMessage);
            }
            _customerDal.Update(customer);
            return new SuccessDataResult<Customers>(Messages.CustomerUpdate);
        }
    }
}
