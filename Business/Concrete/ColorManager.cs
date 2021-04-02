using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Delete(Color color)
        {
            //if (true)//db'de ilişkilendirilmiş bir foreign alan varsa silme.
            //{
            //    return new ErrorResult(Messages.ColorNotDeleted);
            //}
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColorListed);
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == ColorId));
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Update(Color color)
        { 
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
