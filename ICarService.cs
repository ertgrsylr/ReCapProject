using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Business.Abstract
{

    public interface ICarService 
    {
         List<Car> GetAll;
         void Add(Car car);
         void Delete(Car car);
         void Update(Car car);
         car GetById(int id);
         List<Car> GetAllByColorId(int id);
         List<Car> GetAllByBrandId(int id);
         List<Car> GetByDailyPrice(int min, int max);
         List<CarDetailDto> GetCarDetail();
    }
}