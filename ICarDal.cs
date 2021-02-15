using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Entities.Concrete


namespace DataAcccess.Abstract
{

    public interface ICarDal
    {
        List<Car> GetById(int carId);
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}