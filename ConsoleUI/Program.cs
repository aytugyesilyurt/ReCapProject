using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Concrete.Persons;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //Brand brand1 = new Brand() { BrandId = 1, BrandName = "TOYOTA" };
            //Color color1 = new Color() { ColorId = 1, ColorName = "BEYAZ" };
            //Color color2 = new Color() { ColorId = 2, ColorName = "MAVI" };
            //Color color4 = new Color() { ColorId = 4, ColorName = "MAVI" };
            //Color colorBrwn = new Color() { ColorId = 3, ColorName = "KAHVERENGİ" };
            //colorManager.Add(color4);
            //brandManager.Add(brand1);
            //User user1 = new User() { FirstName = "Aytuğ",LastName="YEŞİLYURT",Email="yesilyurt.aytug@hotmail.com",Password="kodlamaio" };
            //Customer customer1 = new Customer() { UserId = 2, CompanyName = "kodlamaio" };
            //Rental rental1 = new Rental() { RentId = 1,CarId = 1, CustomerId = 1, RentDate = DateTime.Now,ReturnDate=new DateTime(2021,6,5) };

            //Console.WriteLine(userManager.Add(user1).Message);
            //Console.WriteLine(customerManager.Add(customer1).Message);
            //Console.WriteLine(rentalManager.Add(rental1));





            //Car car1 = new Car() { CarId = 6, ColorId = 1, BrandId = 1, DailyPrice = 1500, ModelYear = 1996, CarName = "COROLLA", Description = "Sahibinden temiz kelepir (kadın doktordan)" };

            //carManager.GetAll();

            //var result = carManager.GetCarDetails();

            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine("Araç kodu: " + car.CarId + " // Marka Adı: " + car.BrandName + " // Model rengi: " + car.ColorName + " // Fiyatı: " + car.DailyPrice + " // Ürün Adı: " + car.CarName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            Console.ReadLine();
        }
    }
}
