using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            if (_rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null).Count >= 1)
            {
                return new ErrorResult(Messages.DateInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }
        [CacheAspect]
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }
        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }
        public IResult GetRentalsCar(Rental rental)
        {
            if (rental.RentDate > rental.ReturnDate) return new ErrorResult("Teslim tarihi alış tarihinden küçük olamaz.");
            var result = _rentalDal.GetRentalDetails(r => r.CarId == rental.CarId).
                Where(r =>
                        ((r.RentDate == rental.RentDate) && (r.ReturnDate == rental.ReturnDate)) ||
                        ((rental.RentDate >= r.RentDate) && (rental.RentDate <= r.ReturnDate)) ||
                        ((rental.ReturnDate >= r.RentDate) && (rental.ReturnDate <= r.ReturnDate))).ToList();

            if (result.Count > 0)
            {
                string errorMessage = "seçilen tarihler arasında araç zaten kiralanmış.";
                return new ErrorResult(errorMessage);
            }
            return new SuccessResult("seçilen tarihler arasında araç kiralanabilir.");
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}