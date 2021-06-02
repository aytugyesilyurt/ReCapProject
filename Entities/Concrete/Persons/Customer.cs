using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Persons
{
    public class Customer:User,IPerson
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }

    }
}
