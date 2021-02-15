using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete
{

    public static class InMemoryCarDal:ICarDal
    {
        _cars = new List<Car>
        {
           new Car {Id=1,ColorId=1,DailyPrice=155670,ModelYear=2012,Decsription="Dizel-otomatik",BrandId=1},
           new Car {Id=2,ColorId=1,DailyPrice=3714100,ModelYear=2020,Decsription="Dizel-otomatik-9 ileri",BrandId=2},
           new Car {Id=3,ColorId=4,DailyPrice=4321900,ModelYear=2021,Decsription="Benzin-otomatik",BrandId=2},
           new Car {Id=4,ColorId=1,DailyPrice=130000,ModelYear=2008,Decsription="Lpg-manuel",BrandId=4},
           new Car {Id=5,ColorId=2,DailyPrice=80000,ModelYear=2010,Decsription="Dizel-manuel",BrandId=3},
           new Car {Id=6,ColorId=1,DailyPrice=120000,ModelYear=2016,Decsription="Dizel-manuel",BrandId=3},
           new Car {Id=7,ColorId=3,DailyPrice=185550,ModelYear=2019,Decsription="Benzin-otomatik",BrandId=4},
           new Car {Id=8,ColorId=1,DailyPrice=3000000,ModelYear=2019,Decsription="Benzin-manuel",BrandId=1},
        };
        
    }
    public void Add(Car car)
    {
    	_cars.Add(car);
    }
    public void Delete(Car car)
    {
    	Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
    	_cars.Remove(carToDelete);
    }
    
    public List<Car> GetById(int carId)
    {
    	return _cars.Where(c=>cId==car.Id).ToList();
    }
    
    public void Update(Car car)
    {
    	Car carToUpdate = _cars.SingleToDefault(c=>c.Id==car.Id);
    	carToUpdate.ColorId = car.ColorId;
    	carToUpdate.DailyPrice = car.DailyPrice;
    	carToUpdate.Decsription = car.Decsription;
    	carToUpdate.ModelYear = car.ModelYear;
    }
    
    
}