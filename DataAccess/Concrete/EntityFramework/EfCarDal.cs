using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (CarDatabaseContext context = new CarDatabaseContext())
        {
            var result = from car in context.Cars
                join color in context.Colors on car.ColorId equals color.Id
                join brand in context.Brands on car.BrandId equals brand.Id
                join image in context.CarImages on car.Id equals image.CarId into Images
                from image in Images.DefaultIfEmpty()
                group new { car, brand, color, image } by car.Id
                into carGroup
                select new CarDetailDto
                {
                    Id = carGroup.First().car.Id,
                    CarName = carGroup.First().car.CarName,
                    BrandName = carGroup.First().brand.BrandName,
                    ColorName = carGroup.First().color.ColorName,
                    DailyPrice = carGroup.First().car.DailyPrice,
                    CarImage = carGroup.Select(c => c.image == null ? "default.png" : c.image.ImagePath).ToList()
                };
            return result.ToList();
        }
    }

    public List<CarDetailDto> GetDetailsByBrandId(int brandId)
    {
        using (CarDatabaseContext context = new CarDatabaseContext())
        {
            var result = from car in context.Cars
                where car.BrandId == brandId
                join brand in context.Brands on car.BrandId equals brand.Id
                join color in context.Colors on car.ColorId equals color.Id
                join carImage in context.CarImages on car.Id equals carImage.CarId into Images
                from image in Images.DefaultIfEmpty()
                group new { car, brand, color, image } by car.Id
                into carGroup
                select new CarDetailDto
                {
                    Id = carGroup.First().car.Id,
                    CarName = carGroup.First().car.CarName ?? "",
                    BrandName = carGroup.First().brand.BrandName ?? "",
                    ColorName = carGroup.First().color.ColorName ?? "",
                    DailyPrice = carGroup.First().car.DailyPrice,
                    CarImage = carGroup.Select(c => c.image == null ? "default.png" : c.image.ImagePath).ToList()
                };
            return result.ToList();
        }
    }

    public List<CarDetailDto> GetDetailsByColorId(int colorId)
    {
        using (CarDatabaseContext context = new CarDatabaseContext())
        {
            var result = from car in context.Cars
                where car.ColorId == colorId
                join brand in context.Brands on car.BrandId equals brand.Id
                join color in context.Colors on car.ColorId equals color.Id
                join carImage in context.CarImages on car.Id equals carImage.CarId into Images
                from image in Images.DefaultIfEmpty()
                group new { car, brand, color, image } by car.Id
                into carGroup
                select new CarDetailDto
                {
                    Id = carGroup.First().car.Id,
                    CarName = carGroup.First().car.CarName ?? "",
                    BrandName = carGroup.First().brand.BrandName ?? "",
                    ColorName = carGroup.First().color.ColorName ?? "",
                    DailyPrice = carGroup.First().car.DailyPrice,
                    CarImage = carGroup.Select(c => c.image == null ? "default.png" : c.image.ImagePath).ToList()
                };
            return result.ToList();
        }
    }

    public List<CarDetailDto> GetCarDetailsById(int carId)
    {
        using (CarDatabaseContext context = new CarDatabaseContext())
        {
            var result = from car in context.Cars
                where car.Id == carId
                join brand in context.Brands on car.BrandId equals brand.Id
                join color in context.Colors on car.ColorId equals color.Id
                join carImage in context.CarImages on car.Id equals carImage.CarId into Images
                from image in Images.DefaultIfEmpty()
                group new { car, brand, color, image } by car.Id
                into carGroup
                select new CarDetailDto
                {
                    Id = carGroup.First().car.Id,
                    Description = carGroup.First().car.Description,
                    CarName = carGroup.First().car.CarName ?? "",
                    BrandName = carGroup.First().brand.BrandName ?? "",
                    ColorName = carGroup.First().color.ColorName ?? "",
                    DailyPrice = carGroup.First().car.DailyPrice,
                    CarImage = carGroup.Select(c => c.image == null ? "default.png" : c.image.ImagePath).ToList()
                };
            return result.ToList();
        }
    }
}