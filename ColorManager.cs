using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Business.Concrete
{

    public class ColorManager:IColorService
    {
    	   IColorDal = _colorDal;
    	   
         public void Add(Color color)
         {
         	_colorDal.Add();
         }
         public ColorManager(IColorDal colorDal)
         {
         	_colorDal = colorDal;
         }
         public List<Color> GetAll()
         {
         	return _colorDal.GetAll();
         }
         public Color GetById(int colorId)
         {
         	return _colorDal.Get(c=>c.Id == colorId);
         }
    }
}