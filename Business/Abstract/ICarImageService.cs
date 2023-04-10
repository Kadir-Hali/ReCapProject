﻿using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract;

public interface ICarImageService
{
    IDataResult<List<CarImage>> GetAll();
    IDataResult<List<CarImage>> GetByCarId(int carId);
    IDataResult<CarImage> GetByImageId(int imageId);
    IResult Add(IFormFile file, CarImage carImage);
    IResult Update(IFormFile file, CarImage carImage);
    IResult Delete(CarImage carImage);
}