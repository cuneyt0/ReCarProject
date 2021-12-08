using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctre;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IfEntityRepositoryBase<Color, ReCapProjectContext>, IColorDal
    {
       
    }
}
