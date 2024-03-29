﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class RentalManager : IRentalService
{
    private IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }

    public IDataResult<List<RentalDetailDto>> GetRentalDetails()
    {
        return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), RentalMessages.RentalDetailsListed);
    }

    public IResult Add(Rental rental)
    {
        if (rental.ReturnDate != null)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(RentalMessages.RentalAdded);
        }
        else
        {
            return new ErrorResult(RentalMessages.RentalInvalid);
        }
    }

    public IResult Delete(Rental rental)
    {
        _rentalDal.Delete(rental);
        return new SuccessResult(RentalMessages.RentalDeleted);
    }

    public IDataResult<List<Rental>> GetAll()
    {
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), RentalMessages.RentalsListed);
    }

    public IDataResult<Rental> GetById(int id)
    {
        return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), RentalMessages.RentalByIdListed);
    }

    public IResult Update(Rental rental)
    {
        _rentalDal.Update(rental);
        return new SuccessResult(RentalMessages.RentalUpdated);
    }
}