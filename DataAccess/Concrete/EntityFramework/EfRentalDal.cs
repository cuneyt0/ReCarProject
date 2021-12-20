using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rentals, ReCapProjectContext>, IRentalsDal
    {
    }
}
