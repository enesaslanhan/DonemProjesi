﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult <List<User>> GetAll();
        IDataResult<List<KullanıcıDetailDto>> GetKullanıcıDetails();
        IDataResult<User> GetById(int userId);
        IResult Add(User user);
    }
}
