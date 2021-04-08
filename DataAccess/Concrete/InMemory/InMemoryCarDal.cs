using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _products;

        public InMemoryCarDal()
        {
            _products = new List<Car> {
            new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=10,CarName="Araba",ModelYear="2021"}
            };
        }

        public void Add(Car car)
        {
            _products.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _products.SingleOrDefault(p => p.CarId == car.CarId);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _products.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
        public List<Car> GetAll()
        {
            return _products;
        }
        public List<Car> GetById(int carId)
        {
            return _products.Where(p => p.CarId == carId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrandName(string brandName)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorName(string colorName)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetDtoByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetDtoByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
