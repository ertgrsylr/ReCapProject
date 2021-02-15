using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Business.Concrete
{

    public class CarManager:ICarService
    {
    	  ICarDal _carDal;
        public void CarManager(ICarDal carDal)
        {
           _carDal: carDal;
        }
        
        public List<Car> GetAll()
        {
        	return _carDal.GetAll();
        }
    }
}