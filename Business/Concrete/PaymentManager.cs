using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        readonly IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        [ValidationAspect(typeof(PaymentValidator))]
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
           return new SuccessResult(Messages.PaymentSuccessfull);
        }
        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult();
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult();
        }
    }
}
