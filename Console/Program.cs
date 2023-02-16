// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

carManager.Add(new Car {ColorId = 1, BrandId = 1, Description = "Opel Astra", ModelYear = 2016, DailyPrice = 750 });

foreach (var car in carManager.GetAll())
{
   Console.WriteLine(car.Description);
}