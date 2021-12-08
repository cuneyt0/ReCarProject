using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Conctre;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testone();

            CarsManager carsManager = new CarsManager(new EfCarDal());

            foreach (var item in carsManager.GetCarsDetails())
            {
                Console.WriteLine("Araba adı: "+ item.BrandName+ " "+"Araba rengi"+item.ColorName);
            }
        }

        private static void Testone()
        {
            CarsManager carsManager = new CarsManager(new EfCarDal());
            foreach (var cars in carsManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(cars.BrandId + " " + cars.Description);
            }
            Console.WriteLine("---------GetCarsByColorId ---------------");
            foreach (var cars in carsManager.GetCarsByColorId(2))
            {
                Console.WriteLine(cars.BrandId + " " + cars.Description);
            }
        }
    }
}
/*
  //--GellAll metod
              foreach (var cars in carsManager.GetAll())
             {
                 Console.WriteLine(cars.Description);
             }
            

            //--Car add metot
            Cars newCar = new Cars
            {
                Id = 5,
                BrandId = 5,
                ColorId = 5,
                DailyPrice = 900,
                Description = "Last added car",
                ModelYear = 2005,
            };
            Console.WriteLine(" ");
            Console.WriteLine("---------Car Add ---------------");
            carsManager.Add(newCar);



            foreach (var cars in carsManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }

            Console.WriteLine(" ");
            Console.WriteLine("---------Car Delete ---------------");

            carsManager.Delete(newCar);

            foreach (var cars in carsManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }


            Console.WriteLine(" ");
            Console.WriteLine("---------Car Find By Id ---------------");

            foreach (var cars in carsManager.GetById(1))
            {
                Console.WriteLine(cars.Description);
            }
          
        }
 
 
 
 */