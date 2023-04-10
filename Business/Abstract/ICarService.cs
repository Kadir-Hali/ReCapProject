using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetCarsByBrandId(int id);
    IDataResult<List<Car>> GetCarsByColorId(int id);
    IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
    IDataResult<List<CarDetailDto>> GetCarDetails();
    IDataResult<List<CarDetailDto>> GetCarDetailByBrand(int brandId);
    IDataResult<List<CarDetailDto>> GetCarDetailByColor(int colorId);
    IDataResult<List<CarDetailDto>> GetCarDetailByCar(int carId);
    IDataResult<Car> GetById(int carId);
    IResult AddTransactionalTest(Car car);

}