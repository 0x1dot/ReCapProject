using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<CreditCardDto> GetCardByCustomerId(int customerId);
        IDataResult<List<CreditCardDto>> GetCardsByCustomerId(int customerId);
    }
}
