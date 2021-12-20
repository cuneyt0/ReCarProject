using Business.Concrete;
using Core.Entities.Concrete;
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

            //TestTwo();
            /****-----Users-------*****/
            //UserAddTest();

            //UserDeleteTest();

            //UserGetAll();

            //UserUpdate();
            //UserGetById();

            //*******----Customer---******//
            //CustomersAddTest();

            //CustomerDeleteTest();
            // CustomerUpdateTest();

            // CustomerGetAllTest();
            // CustomerGetById();

            /**----Rentals ---**/

            //RentalAddTest();
            //RentalDeleteTest();
            //RentalUpdateTest();
            //RentalGetAllTest();
            //GetRentalByIdTest();

        }

        private static void GetRentalByIdTest()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalDal());

            var result = rentalsManager.GetRentalById(1);

            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data.Id.ToString())
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void RentalGetAllTest()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalDal());

            var result = rentalsManager.GetAll();

            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + " Verilen Tarih: " + item.RentDate + " " + " Teslim Tarih: " + item.ReturnDate);
                }
            }
        }

        private static void RentalUpdateTest()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalDal());
            Rentals updateRentals = new Rentals { Id = 3, CarId = 2, CustomerId = 1, RentDate = DateTime.Now.Date, ReturnDate = DateTime.Today };
            var result = rentalsManager.Update(updateRentals);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalDeleteTest()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalDal());
            Rentals deleteRentals = new Rentals { Id = 4, CarId = 1, CustomerId = 2, RentDate = DateTime.Now.Date, ReturnDate = DateTime.Today };
            var result = rentalsManager.Delete(deleteRentals);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAddTest()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalDal());
            Rentals newRentals = new Rentals { Id = 4, CarId = 1, CustomerId = 2, RentDate = DateTime.Now.Date, ReturnDate = DateTime.Today };
            var result = rentalsManager.Add(newRentals);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerGetById()
        {
            CustomersManager customersManager = new CustomersManager(new EfCustomerDal());
            var result = customersManager.GetCustomerById(1);

            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data.CompanyName)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void CustomerGetAllTest()
        {
            CustomersManager customersManager = new CustomersManager(new EfCustomerDal());
            var result = customersManager.GetAll();

            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CompanyName);
                }
            }
        }

        private static void CustomerUpdateTest()
        {
            CustomersManager customersManager = new CustomersManager(new EfCustomerDal());
            Customers updatecustomer = new Customers { CustomerId = 3, UserId = 1, CompanyName = "Encom Holding" };

            var result = customersManager.Update(updatecustomer);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerDeleteTest()
        {
            CustomersManager customersManager = new CustomersManager(new EfCustomerDal());
            Customers deletecustomers = new Customers { CustomerId = 4, UserId = 1, CompanyName = "Encom Holding" };

            var result = customersManager.Delete(deletecustomers);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        private static void CustomersAddTest()
        {
            CustomersManager customersManager = new CustomersManager(new EfCustomerDal());
            Customers newcustomers = new Customers { CustomerId = 3, UserId = 1, CompanyName = "Encom Holding" };

            var result = customersManager.Add(newcustomers);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserGetById()
        {
            UserManager usersManager = new UserManager(new EfUserDal());

            var result = usersManager.GetUsersById(1);

            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data.FirstName)
                {
                    Console.WriteLine(item);
                }
            }
        }

        /*
            private static void UserUpdate()
           {
               UserManager usersManager = new UserManager(new EfUserDal());
               User newUser = new User { Id = 4, FirstName = "Levent", LastName = "Taha", Email = "123@gmail.com", PasswordHash = 123 };

               var result = usersManager.Update(newUser);
               if (result.Success == false)
               {
                   Console.WriteLine(result.Message);
               }
               else
               {
                   Console.WriteLine(result.Message);
               }
           }

         */

        private static void UserGetAll()
        {
            UserManager usersManager = new UserManager(new EfUserDal());

            var result = usersManager.GetAll();

            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.FirstName);
                }
            }
        }

        /*
          private static void UserDeleteTest()
         {
             UserManager usersManager = new UserManager(new EfUserDal());
             Users newUser = new Users { Id = 5, FirstName = "Apo", LastName = "Taha", Email = "123@gmail.com", Password = 123 };

             var result = usersManager.Delete(newUser);
             if (result.Success == false)
             {
                 Console.WriteLine(result.Message);
             }
             else
             {
                 Console.WriteLine(result.Message);
             }
         }

         */

        /*
           private static void UserAddTest()
          {
              UserManager usersManager = new UserManager(new EfUserDal());
              Users newUser = new Users { Id = 5, FirstName = "Apo", LastName = "Taha", Email = "123@gmail.com", Password = 123 };

              var result = usersManager.Add(newUser);
              if (result.Success == false)
              {
                  Console.WriteLine(result.Message);
              }
              else
              {
                  Console.WriteLine(result.Message);
              }
          }

         */

        private static void TestTwo()
        {
            CarsManager carsManager = new CarsManager(new EfCarDal());

            var result = carsManager.GetCarsDetails();
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("Araba adı: " + item.BrandName + " " + "Araba rengi" + item.DailyPrice);
                }

            }
        }

        private static void Testone()
        {
            CarsManager carsManager = new CarsManager(new EfCarDal());
            foreach (var cars in carsManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(cars.BrandId + " " + cars.Description);
            }
            Console.WriteLine("---------GetCarsByColorId ---------------");
            foreach (var cars in carsManager.GetCarsByColorId(2).Data)
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