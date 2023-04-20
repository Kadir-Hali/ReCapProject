﻿using Core.Utilities.Results;

namespace Business.Abstract;

public interface IFindeksService
{
    IDataResult<int> GetFindeksScore(int userId);
}