using Core.DataAccess;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customers> 
    {
    }
}
