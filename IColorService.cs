using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Business.Abstract
{

    public interface IColorService 
    {
         List<Color> GetAll();
         Color GetById(int colorId);
    }
}