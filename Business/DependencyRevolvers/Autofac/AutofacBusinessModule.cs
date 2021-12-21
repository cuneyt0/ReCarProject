using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilitiess.Helpers.FileHelper;
using Core.Utilitiess.Interceptors;
using Core.Utilitiess.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

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
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            //Cars
            builder.RegisterType<CarsManager>().As<ICarsServices>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            //Customers
            builder.RegisterType<CustomersManager>().As<ICustomersServices>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            //Rentals
            builder.RegisterType<RentalsManager>().As<IRentalServices>().SingleInstance();
            builder.RegisterType<EfRentalDal>().As<IRentalsDal>().SingleInstance();
            //CarImage
            builder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();
            builder.RegisterType<EfCarImageDal>().As<ICarImageDal>().SingleInstance();

            builder.RegisterType<FileHeplerManager>().As<IFileHelper>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
