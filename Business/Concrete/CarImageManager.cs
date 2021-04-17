using Business.Abstract;
using Business.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageOfCountOverflow(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = System.DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }
        public IResult Delete(CarImage carImage)
        {
            File.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageOfCountOverflow(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            var formerPath = _carImageDal.Get(carImage => carImage.CarImageId == carImage.CarImageId).ImagePath;
            carImage.ImagePath = FileHelper.Update(formerPath, file);
            carImage.Date = System.DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetCarImages(int carId)
        {
            var result = BusinessRules.Run(CheckIfNullCarImage(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(result.Message);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i => i.CarId == carId));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> Get(int imageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarImageId == imageId));
        }
        private IResult CheckIfCarImageOfCountOverflow(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        private IDataResult<List<CarImage>> CheckIfNullCarImage(int CarId)
        {
            try
            {
                string path = @"\wwwroot\images\default.jpg";
                var result = _carImageDal.GetAll(i => i.CarId == CarId).Any();
                if (!result)
                {
                    List<CarImage> images = new List<CarImage>();
                    images.Add(new CarImage() { CarId = CarId, Date = DateTime.Now, ImagePath = path });
                    return new SuccessDataResult<List<CarImage>>(images);
                }

            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<CarImage>>(e.Message);
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i => i.CarId == CarId));
        }
    }
}
