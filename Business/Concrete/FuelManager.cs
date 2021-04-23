using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        readonly IFuelDal _fuelDal;

        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        public IResult Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
            return new SuccessResult();
        }

        public IResult Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);
            return new SuccessResult();
        }

        public IDataResult<List<Fuel>> GetAll()
        {
            return new SuccessDataResult<List<Fuel>>(_fuelDal.GetAll());
        }

        public IResult Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
            return new SuccessResult();
        }
    }
}
