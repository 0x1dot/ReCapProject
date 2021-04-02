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
            //CarTest();
            //BrandTest();
            //ColorTest();
            //CarTest1();
            //CustomerTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now };
            Console.WriteLine(rentalManager.Add(rental).Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { UserId = 1, CompanyName = "XXInterCyborg" };
            Console.WriteLine(customerManager.Add(customer).Message);
        }

        private static void CarTest1()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.ModelYear + "/" + car.DailyPrice);
                }
            }
            else Console.WriteLine(result.Message);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color
            {
                ColorName = "Kırmızı"
            };

            colorManager.Add(color1);
            Console.WriteLine("Renk verisi eklendi.");
            foreach (Color brand in colorManager.GetAll().Data)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Renk ismi:" + brand.ColorName);
                Console.WriteLine("--------------------");
            }
            var renk = colorManager.GetById(1);
            Console.WriteLine(renk.Data.ColorName + " GetById fonksiyonu çalıştırıldı.");

            colorManager.Delete(color1);
            Console.WriteLine("Renk verisi silindi");
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand
            {
                BrandName = "Mercedes"
            };

            brandManager.Add(brand1);
            Console.WriteLine("Marka verisi eklendi.");

            foreach (Brand brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Marka ismi:" + brand.BrandName);
                Console.WriteLine("--------------------");
            }
            var marka = brandManager.GetById(1);
            Console.WriteLine(marka.Data.BrandName + " GetById fonksiyonu çalıştırıldı.");

            brandManager.Delete(brand1);
            Console.WriteLine("Marka verisi silindi");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car
            {
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 700,
                CarName = "X5",
                ModelYear = "2020"
            };

            carManager.Add(car1);
            Console.WriteLine("Araba verisi eklendi.");
            
            foreach (Car car in carManager.GetAll().Data)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Model Yılı:" + car.ModelYear);
                Console.WriteLine("Markası:" + car.BrandId);
                Console.WriteLine("İsmi:" + car.CarName);
                Console.WriteLine("Rengi:" + car.ColorId);
                Console.WriteLine("Günlük Kiralama Ücreti:" + car.DailyPrice);
                Console.WriteLine("--------------------");
            }
            var arac = carManager.GetById(1);
            Console.WriteLine(arac.Data.CarName + " GetById fonksiyonu çalıştırıldı.");

            carManager.Delete(car1);
            Console.WriteLine("Araba verisi silindi");
        }
    }
}
