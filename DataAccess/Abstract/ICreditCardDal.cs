using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICreditCardDal : IEntityRepository<CreditCard>
    {
        CreditCardDto GetCardDetails(Expression<Func<CreditCardDto, bool>> filter = null);
        List<CreditCardDto> GetCardsDetails(Expression<Func<CreditCardDto, bool>> filter = null);
        CreditCardDto GetCardByCustomerId(int customerId);
    }
}