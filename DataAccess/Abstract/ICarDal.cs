﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface ICarDal : IEntityRepository<Car>
{
    List<CarDetailDto> GetCarDetails();

    List<CarDetailDto> GetCarDetailsByBrandId(int brandId);

    List<CarDetailDto> GetCarDetailsByColorId(int colorId);

    List<CarDetailDto> GetCarDetailsById(int carId);
}