using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage image);
        IResult Update(IFormFile file, CarImage image);
        IResult Delete(CarImage image);
        IDataResult<List<CarImage>> GetCarImages(int carId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get(int imageId);
    }
}
