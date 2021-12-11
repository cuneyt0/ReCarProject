using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctre;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IfEntityRepositoryBase<Cars, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarsDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from cr in context.Cars
                             join cl in context.Colors on cr.ColorId equals cl.ColorId
                             join br in context.Brands on cr.BrandId equals br.BrandId
                             select new CarDetailsDto {
                                 Id=cr.Id,
                                 BrandName = br.BrandName,
                                 ColorName=cl.ColorName,
                                 DailyPrice=cr.DailyPrice

                             };

                return result.ToList();
            }
            
        }
    }
}
/*
 Id = cr.Id,
                                 BrandName = br.BrandName,
                                 ColorName = cl.ColorName, 
                                 DailyPrice = cr.DailyPrice*/