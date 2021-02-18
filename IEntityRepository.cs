using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess.Abstract
{

    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
         T Get(Expression<Func<T,bool>> filter);
         List<T> GetAll(Expression<Func<T,bool>> filter = null);
         void Add(T entity);
         void Delete(T entity);
         void Update(T entity);
         
    }
}