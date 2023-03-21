using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;
    public InMemoryCarDal()
    {
        _cars = new List<Car> { 
                
            new Car { Id = 1,BrandId=1,ColorId=3,ModelYear=2018,DailyPrice=550,Description="Opel Astra"},
            new Car { Id = 2,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=250,Description="Opel Vectra"},
            new Car { Id = 3,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=700,Description="Ford Focus"},
            new Car { Id = 4,BrandId=2,ColorId=4,ModelYear=2022,DailyPrice=1250,Description="Mercedes C200"},
            new Car { Id = 5,BrandId=4,ColorId=2,ModelYear=2017,DailyPrice=600,Description="BMW 320d"}
        };
    }
    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        //LINQ - Language Integrated Query
        Car carToDelete = null ;
        carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        _cars.Remove(carToDelete);
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetById(int Id)
    {
        return _cars.Where(c => c.Id == Id).ToList();
    }

    public List<CarDetailDto> GetCarDetails()
    {
        throw new NotImplementedException();
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.Description = car.Description;
    }
}