using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsDetails();
        IDataResult<List<CarDetailDto>> GetDtoByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetDtoByColorId(int colorId);
        IDataResult<CarDetailDto> GetDtoById(int carId);
        IDataResult<List<CarDetailDto>> GetDtoBrandAndColorId(int brandId,int colorId);
    }
}
