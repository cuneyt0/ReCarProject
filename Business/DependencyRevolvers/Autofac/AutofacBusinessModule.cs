using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyRevolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            //Users
            builder.RegisterType<UsersManager>().As<IUsersServices>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUsersDal>().SingleInstance();
            //Cars
            builder.RegisterType<CarsManager>().As<ICarsServices>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            //Customers
            builder.RegisterType<CustomersManager>().As<ICustomersServices>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            //Rentals
            builder.RegisterType<RentalsManager>().As<IRentalServices>().SingleInstance();
            builder.RegisterType<EfRentalDal>().As<IRentalsDal>().SingleInstance();


        }
    }
}
