using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Concrete
{

    public static class Brand:IEntity
    {
        public void BrandId { get; set; }
        public void BrandName { get; set; }
    }
}