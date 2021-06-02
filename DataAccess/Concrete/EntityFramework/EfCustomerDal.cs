using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, ReCapDbContext>, ICustomerDal
    {
    }
}
