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

            Brand brand1 = new Brand() { BrandId = 1, BrandName = "TOYOTA" };
            Color color1 = new Color() { ColorId = 1, ColorName = "BEYAZ" };
            Color color2 = new Color() { ColorId = 2, ColorName = "SİYAH" };
            Color colorBrwn = new Color() { ColorId = 3, ColorName = "KAHVERENGİ" };
            //colorManager.Add(colorBrwn);
            //brandManager.Update(brand1);


            Car car1 = new Car() {CarId=1, ColorId = 1, BrandId = 1, DailyPrice = 1500, ModelYear = 1996, Name = "COROLLA", Description = "Sahibinden temiz satılık 1.6 kaçmaz" };

            carManager.Update(car1);

            carManager.GetAll();

            foreach (var car in carManager.GetAll())
            {

                Console.WriteLine("Araç kodu: "+car.CarId +" // Marka kodu: "+car.BrandId+" // Model yılı: "+car.ModelYear + " // Fiyatı: " + car.DailyPrice + " // Ürün Açıklaması: " + car.Description);
            }

            Console.ReadLine();
        }
    }
}
