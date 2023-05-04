using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete;

public class UserManager : IUserService
{
    private IUserDal _user;

    public UserManager(IUserDal user)
    {
        _user = user;
    }

    public IResult Add(User user)
    {
        _user.Add(user);
        return new SuccessResult(UserMessages.UserAdded);
    }

    public IResult Delete(User user)
    {
        _user.Delete(user);
        return new SuccessResult(UserMessages.UserDeleted);
    }

    public IDataResult<List<User>> GetAll()
    {
        return new SuccessDataResult<List<User>>(_user.GetAll(), UserMessages.UsersListed);
    }

    public User GetByEmail(string email)
    {
        var result = _user.Get(u => u.Email == email);
        return result;
    }

    public IDataResult<User> GetById(int userId)
    {
        return new SuccessDataResult<User>(_user.Get(u => u.Id == userId), UserMessages.UserByIdListed);
    }

    public List<OperationClaim> GetClaims(User user)
    {
        var result = _user.GetClaims(user);
        return result;
    }

    public IResult Update(User user)
    {
        _user.Update(user);
        return new SuccessResult(UserMessages.UserUpdated);
    }
}