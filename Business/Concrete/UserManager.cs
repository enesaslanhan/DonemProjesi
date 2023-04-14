using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _kullanıcıDal;

        public UserManager(IUserDal kullanıcıDal)
        {
            _kullanıcıDal = kullanıcıDal;
        }

        public IResult Add(User user)
        {
            if (user.firstName.Length<2)
            {
                return new ErrorResult(Messages.UserNameInvalid);
            }
            _kullanıcıDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<User>>(_kullanıcıDal.GetAll(),Messages.UserListed);
            
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_kullanıcıDal.Get(p => p.userId == userId));
        }

        public IDataResult<List<KullanıcıDetailDto>> GetKullanıcıDetails()
        {
            return new SuccessDataResult<List<KullanıcıDetailDto>>(_kullanıcıDal.GetKullanıcıDetails());
        }
        
    }
}
