﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager : IColorService
{
    private IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IResult Add(Color color)
    {
        _colorDal.Add(color);
        return new SuccessResult(ColorMessages.ColorAdded);
    }

    public IResult Delete(Color color)
    {
        _colorDal.Delete(color);
        return new SuccessResult(ColorMessages.ColorDeleted);
    }

    public IDataResult<List<Color>> GetAll()
    {
        return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), ColorMessages.ColorsListed);
    }

    public IDataResult<Color> GetById(int colorId)
    {
        return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == colorId), ColorMessages.ColorByIdListed);
    }

    public IResult Update(Color color)
    {
        _colorDal.Update(color);
        return new SuccessResult(ColorMessages.ColorUpdated);
    }
}