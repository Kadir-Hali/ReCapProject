using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    [SecuredOperation("car.add")]
    [ValidationAspect(typeof(CarValidator))]
    [CacheRemoveAspect("IProductService.Get")]
    public IResult Add(Car car)
    {
        _carDal.Add(car);
        return new SuccessResult(CarMessages.CarAdded);

    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(CarMessages.CarDeleted);
    }

    [CacheAspect]
    [PerformanceAspect(5)]
    public IDataResult<List<Car>> GetAll()
    {
        if (DateTime.Now.Hour == 16)
        {
            return new ErrorDataResult<List<Car>>(SystemMessages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), CarMessages.CarsListed);
    }

    public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max), CarMessages.CarByDailyPriceListed);
    }

    public IDataResult<Car> GetById(int carId)
    {
        return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId), CarMessages.CarByIdListed);
    }

    [TransactionScopeAspect]
    public IResult AddTransactionalTest(Car car)
    {
        Add(car);
        if (car.DailyPrice < 100)
        {
            throw new Exception("");
        }
        Add(car);
        return null;
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        if (DateTime.Now.Hour == 15)
        {
            return new ErrorDataResult<List<CarDetailDto>>(SystemMessages.MaintenanceTime);
        }
        else
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), CarMessages.CarDetailsListed);
        }

    }

    public IDataResult<List<Car>> GetCarsByBrandId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id), CarMessages.CarsBrandListed);
    }

    public IDataResult<List<Car>> GetCarsByColorId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), CarMessages.CarsColorListed);
    }

    [ValidationAspect(typeof(CarValidator))]
    [CacheRemoveAspect("ICarService.Get")]
    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(CarMessages.CarUpdated);
    }
}