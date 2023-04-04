using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfRentalDal:EfEntityRepositoryBase<Rental,CarDatabaseContext>,IRentalDal
{
    public List<RentalDetailDto> GetRentalDetails()
    {
        using (CarDatabaseContext context = new CarDatabaseContext())
        {
            var result = from r in context.Rentals
                join u in context.Users
                    on r.CustomerId equals u.Id
                join c in context.Cars
                    on r.CarId equals c.Id

                select new RentalDetailDto()
                {
                    CarName = c.CarName,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    RentDate = r.RentDate,
                    ReturnDate = r.ReturnDate
                };
            return result.ToList();
        }
    }
}