using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IResult Add(Fuel fuel);
        IResult Delete(Fuel fuel);
        IResult Update(Fuel fuel);
        IDataResult<List<Fuel>> GetAll();
    }
}
