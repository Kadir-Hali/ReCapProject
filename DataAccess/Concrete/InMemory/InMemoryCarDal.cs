using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
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
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
