using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.DataAccessLayer.Abstract
{
   public interface IRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        List<T> Get(Expression<Func<T,bool>> filter);

        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
