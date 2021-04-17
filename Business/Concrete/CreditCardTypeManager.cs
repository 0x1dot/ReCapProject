using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CreditCardTypeManager : ICreditCardTypeService
    {
        private readonly ICreditCardTypeDal _creditCardTypeDal;

        public CreditCardTypeManager(ICreditCardTypeDal creditCardTypeDal)
        {
            _creditCardTypeDal = creditCardTypeDal;
        }
        [ValidationAspect(typeof(CreditCardTypeValidator))]
        public IResult Add(CreditCardType creditCardType)
        {
            _creditCardTypeDal.Add(creditCardType);
            return new SuccessResult(Messages.CardTypeAddedSuccessfully);
        }
        [ValidationAspect(typeof(CreditCardTypeValidator))]
        public IResult Update(CreditCardType creditCardType)
        {
            _creditCardTypeDal.Update(creditCardType);
            return new SuccessResult(Messages.CardTypeUpdatedSuccessfully);
        }

        public IResult Delete(CreditCardType creditCardType)
        {
            _creditCardTypeDal.Delete(creditCardType);
            return new SuccessResult(Messages.CardTypeDeletedSuccessfully);
        }

        public IDataResult<List<CreditCardType>> GetAll()
        {
            return new SuccessDataResult<List<CreditCardType>>(_creditCardTypeDal.GetAll(),
                Messages.GetAllCardTypesSuccessfully);
        }

        public IDataResult<CreditCardType> GetCardTypeById(int typeId)
        {
            return new SuccessDataResult<CreditCardType>(_creditCardTypeDal.Get(c => c.Id == typeId), Messages.GetTypeByIdSuccessfully);
        }
    }
}