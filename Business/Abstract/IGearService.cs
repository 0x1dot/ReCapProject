using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGearService
    {
        IResult Add(Gear gear);
        IResult Delete(Gear gear);
        IResult Update(Gear gear);
        IDataResult<List<Gear>> GetAll();
    }
}
