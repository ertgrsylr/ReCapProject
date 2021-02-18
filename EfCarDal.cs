using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DataAcces.Concrete.EntityFreamwork
{

    public class EfCarDal:ICarDal
    {
         public void Add(Car entity)
         {
         	using (CarDBContext context = new CarDBContext())
         	{
         		var addedCar = context.Entry(entity);
         		addedCar.State = EntityState.Added;
         		context.SaveChanged();
         	}
         }
         public void Update(Car entity)
         {
         	using (CarDBContext context = new CarDBContext())
         	{
         		var updatedCar = context.Entry(entity);
         		updatedCar.State = EntityState.Modified;
         		context.SaveChanged();
         	}
         }
         public void Delete(Car entity)
         {
         	using (CarDBContext context = new CarDBContext())
         	{
         		var deletedCar = context.Entry(entity);
         		deletedCar.State = EntityState.Deleted;
         		context.SaveChanged();
         	}
         }
         public List<Car> GetAll(Expression<Func<Car,bool>> filter=null)
         {
         	using (CarDBContext context = new CarDBContext())
         	{
         		return filter == null
         		? context.Set<Car>().ToList();
         		: context.Set<Car>().Where(filter).ToList();
         	}
         }
         public Car Get(Expression<Func<Car,bool>> filter)
         {
         	using (CarDBContext context = new CarDBContext())
         	{
         		return context.Set<Car>().SingleOrDefault(filter);
         	}
         }
    }
}