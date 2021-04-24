using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }

    }
}
