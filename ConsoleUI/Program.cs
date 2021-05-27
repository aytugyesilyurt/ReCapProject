using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Brand brand1 = new Brand() { BrandId = 1, BrandName = "TOYOTA" };
            //Color color1 = new Color() { ColorId = 1, ColorName = "BEYAZ" };
            //Color color2 = new Color() { ColorId = 2, ColorName = "SİYAH" };
            //Color colorBrwn = new Color() { ColorId = 3, ColorName = "KAHVERENGİ" };
            //colorManager.Add(color1);
            //brandManager.Add(brand1);


            //Car car1 = new Car() {CarId=1, ColorId = 1, BrandId = 1, DailyPrice = 1500, ModelYear = 1996, CarName = "COROLLA", Description = "Sahibinden temiz satılık 1.6 kaçmaz" };

            ////carManager.Add(car1);

            //carManager.GetAll();
            
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç kodu: " + car.CarId + " // Marka Adı: " + car.BrandName + " // Model rengi: " + car.ColorName + " // Fiyatı: " + car.DailyPrice + " // Ürün Adı: " + car.CarName);
            }

            Console.ReadLine();
        }
    }
}
