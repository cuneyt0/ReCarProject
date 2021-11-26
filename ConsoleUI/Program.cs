using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Conctre;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsManager carsManager = new CarsManager(new InMemoryCarDal());


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
    }
}
