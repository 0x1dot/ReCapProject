using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserFindeksPointManager : IUserFindexPointService
    {
        IUserFindeksPointDal _UserFindeksPointDal;


        public UserFindeksPointManager(IUserFindeksPointDal userFindeksPointDal)
        {
            _UserFindeksPointDal = userFindeksPointDal;
        }
        public IResult Add(UserFindeksPoint userFindeksPoint)
        {
            userFindeksPoint.FindeksPoint = 100;
            _UserFindeksPointDal.Add(userFindeksPoint);
            return new SuccessResult(Messages.FindeksPointCreated);
        }

        public IResult Delete(UserFindeksPoint userFindeksPoint)
        {
            _UserFindeksPointDal.Delete(userFindeksPoint);
            return new SuccessResult(Messages.FindeksPointDeleted);
        }

        public IDataResult<UserFindeksPoint> GetFindeksPointByCustomerId(int CustomerId)
        {
            return new SuccessDataResult<UserFindeksPoint>(_UserFindeksPointDal.Get(u => u.CustomerId == CustomerId));
        }

        public IResult Update(UserFindeksPoint userFindeksPoint)
        {
            IResult result = BusinessRules.Run(UpdateFindeksPoint(userFindeksPoint.CustomerId));
            if (result != null)
            {
                return result;
            }

            var result2 = _UserFindeksPointDal.Get(u => u.CustomerId == userFindeksPoint.CustomerId);
            userFindeksPoint.FindeksPoint = result2.FindeksPoint + 300;
            _UserFindeksPointDal.Update(userFindeksPoint);
            return new SuccessResult(Messages.FindeksPointUpdated);
        }

        // Business Rules

        private IResult UpdateFindeksPoint(int CustomerId)
        {
            var result = _UserFindeksPointDal.Get(u => u.CustomerId == CustomerId);
            if (result.FindeksPoint >= 1900)
            {
                return new ErrorResult(Messages.MaxFindeksPointExceeded);
            }
            return new SuccessResult();
        }
    }
}
