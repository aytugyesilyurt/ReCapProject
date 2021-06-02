﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Persons;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapDbContext>, IUserDal
    {
        
    }
}
