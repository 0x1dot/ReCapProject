using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserFindexPointService
    {

        IDataResult<UserFindeksPoint> GetFindeksPointByCustomerId(int customerId);
        IResult Add(UserFindeksPoint userFindeksPoint);
        IResult Delete(UserFindeksPoint userFindeksPoint);
        IResult Update(UserFindeksPoint userFindeksPoint);
    }
}
