using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Core.DataAccess.EntityFramework
{

    public class EfEntityRepositoryBase<TEntity,TContext> : EntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {
         public void Add(TEntity entity)
         {
         	using (TContext context = new TContext())
         	{
         	   var addedEntity = context.Entry(entity)
         	   addedEntity.State = EntityState.Added;
          	   context.SaveChanges();
         	}
         }
         
         public void delete(TEntity entity)
         {
         	using (TContext context = new TContext())
         	{
         	   var DeletedEntity = context.Entry(entity)
         	   deletedEntity.State = EntityState.Deleted;
          	   context.SaveChanges();
         	}
         }
         public void Update(TEntity entity)
         {
         	using (TContext context = new TContext())
         	{
         	   var updatedEntity = context.Entry(entity)
         	   updatedEntity.State = EntityState.Updated;
          	   context.SaveChanges();
         	}
         }
         public TEntity Get(Expression<Func<TEntity,bool>> filter)
         {
         	using (TContext context = new TContext())
         	{
         		return context.Set<TEntity>().SingleOrDefault(filter)
         	}
         }
         public List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter= null)
         {
         	using (TContext context = new TContext())
         	{
         		return filter == null
         		  ? context.Set<TEntity>().ToList()
         		  : context.Set<TEntity>().Where(filter).ToList();
         	}
         }
         
         
    }
}