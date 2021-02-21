using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Business.Abstract
{

    public interface IBrandService 
    {
         List<Brand> GetAll();
         Brand GetById(int brandId);
    }
}