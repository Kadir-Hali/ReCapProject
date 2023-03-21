using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (CarDatabaseContext context= new CarDatabaseContext())
        {
            var result = from c in context.Cars
                join co in context.Colors
                    on c.ColorId equals co.Id
                join b in context.Brands
                    on c.BrandId equals b.Id

                select new CarDetailDto
                {
                    Description= c.Description,
                    BrandName=b.BrandName,
                    ColorName=co.ColorName,
                    DailyPrice=c.DailyPrice
                };
            return result.ToList();
        }
    }
}