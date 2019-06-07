using Siparis.Core.DataAccessLayer.Abstract;
using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Siparis.Core.DataAccessLayer.Concart.EntityFramework
{
    public class EntityFrameworkRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var reference = context.Entry(entity);
                reference.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Delete(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var reference = context.Entry(entity);
                reference.State = EntityState.Deleted;
                context.SaveChanges();
                return entity;
            }
        }

        public List<TEntity> Get(Expression<Func<TEntity,bool>> filter)
        {
            using(TContext context=new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null)
        {
            using(TContext context=new TContext())
            {
                return filter != null ? context.Set<TEntity>().Where(filter).ToList() : context.Set<TEntity>().ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var reference = context.Entry(entity);
                reference.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
    }
}
