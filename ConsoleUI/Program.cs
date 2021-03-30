using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car
            {
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 700,
                Description = "X5",
                ModelYear = "2020"
            };
            Console.WriteLine("Araba verisi eklendi.");
            carManager.Add(car1);

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Model Yılı:" + car.ModelYear);
                Console.WriteLine("Markası:" + car.BrandId);
                Console.WriteLine("Modeli:" + car.Description);
                Console.WriteLine("Rengi:" + car.ColorId);
                Console.WriteLine("Günlük Kiralama Ücreti:" + car.DailyPrice);
                Console.WriteLine("--------------------");
            }

            carManager.Delete(car1);
            Console.WriteLine("Araba verisi silindi");
        }
    }
}
