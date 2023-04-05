using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDatabaseContext>, IRentalDal
{
    public List<RentalDetailDto> GetRentalDetails()
    {
        using (CarDatabaseContext context = new CarDatabaseContext())
        {
            var result = from rental in context.Rentals
                         join user in context.Users on rental.CustomerId equals user.Id
                         join car in context.Cars on rental.CarId equals car.Id

                         select new RentalDetailDto()
                         {
                             Id = rental.Id,
                             CarName = car.CarName,
                             FirstName = user.FirstName,
                             LastName = user.LastName,
                             RentDate = rental.RentDate,
                             ReturnDate = rental.ReturnDate
                         };
            return result.ToList();
        }
    }
}