// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarTest();
//ColorTest();
//BrandTest();
RentalTest();

static void RentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());

    var result = rentalManager.GetAll();

    if (result.Success == true)
    {
        foreach (var rental in result.Data)
        {
            Console.WriteLine(rental.Id + "/" + rental.CarId + "/" +rental.RentDate );
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}
static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var result = carManager.GetCarDetails();

    if (result.Success == true)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.Description + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}

    static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        var result = colorManager.GetAll();
        if (result.Success == true)
        {
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);

            }
        }

    }

    static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result = brandManager.GetAll();
        if (result.Success == true)
        {
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

    }
