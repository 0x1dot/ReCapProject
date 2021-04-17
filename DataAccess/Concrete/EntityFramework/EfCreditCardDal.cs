using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCreditCardDal : IEntityRepositoryBase<CreditCard, ReCapContext>, ICreditCardDal
    {
        public CreditCardDto GetCardByCustomerId(int customerId)
        {
            return GetCardsDetails(c => c.CustomerId == customerId).OrderBy(c => c.Id).LastOrDefault();
        }

        public CreditCardDto GetCardDetails(Expression<Func<CreditCardDto, bool>> filter = null)
        {
            return GetCardsDetails(filter).FirstOrDefault();
        }

        public List<CreditCardDto> GetCardsDetails(Expression<Func<CreditCardDto, bool>> filter = null)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from creditCard in reCapContext.CreditCards
                             join creditCardType in reCapContext.CreditCardTypes 
                             on creditCard.CardTypeId equals creditCardType.Id
                             select new CreditCardDto
                             {
                                 Id = creditCard.Id,
                                 CustomerId = creditCard.CustomerId,
                                 CardTypeId = creditCard.CardTypeId,
                                 CardTypeName = creditCardType.TypeName,
                                 CardNumber = creditCard.CardNumber,
                                 FirstName = creditCard.FirstName,
                                 LastName = creditCard.LastName,
                                 ExpirationMonth = creditCard.ExpirationMonth,
                                 ExpirationYear = creditCard.ExpirationYear,
                                 Cvv = creditCard.Cvv
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}