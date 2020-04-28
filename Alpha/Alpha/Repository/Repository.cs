using Alpha.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;


namespace Alpha.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        CovidDatacontext context;
        public Repository()
        {
            context = new CovidDatacontext();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Set<TEntity>().Remove(this.Get(id));
            context.SaveChanges();
        }
    }
}