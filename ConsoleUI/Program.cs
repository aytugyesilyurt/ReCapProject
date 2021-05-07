using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.GetAll();

            //foreach (var car in carManager.GetAll())
            //{
                
            //    //Console.WriteLine("Araç kodu: "+car.CarId +" // Marka kodu: "+car.BrandId+" // Model yılı: "+car.ModelYear + " // Fiyatı: " + car.DailyPrice + " // Ürün Açıklaması: " + car.Description);
            //}

            Console.ReadLine();
        }
    }
}
