using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : IEntityRepositoryBase<Rental,ReCapContext>, IRentalDal
    {
        RentalDetailDto _carDetailDto;

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from r in reCapContext.Rentals
                            join c in reCapContext.Cars
                            on r.CarId equals c.CarId
                            join b in reCapContext.Brands
                            on c.BrandId equals b.BrandId
                           join ct in reCapContext.Customers
                            on r.CustomerId equals ct.CustomerId
                            join u in reCapContext.Users
                            on ct.UserId equals u.UserId 
                             select new RentalDetailDto
                             {
                              RentalId = r.RentalId,
                              CarId = r.CarId,
                              BrandName = b.BrandName,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              RentDate = r.RentDate,
                              ReturnDate = r.ReturnDate
                             };
                return filter != null ? result.Where(filter).ToList() : result.ToList();
            }
        }
    }
}
