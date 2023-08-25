using MyProject.DataAccess.Abstract;
using MyProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Persistence.Repositories;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class , IEntity, new()
        where TContext : DbContext , new()

        //class olmalı IEntityden implemente edilmeli newlenebilir olmalı ,
        // Tcontext'in dbcontexden inherit edilmeli newlenebilir olmalı 
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //Veritabanında ilgili nesneye erişmek 
                addedEntity.State= EntityState.Added;  
                context.SaveChanges(); 
            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State= EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter )
        {
           using(TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext sqlContext = new TContext())
            {
                return filter == null ? sqlContext.Set<TEntity>().ToList() : sqlContext.Set<TEntity>().Where(filter).ToList();     // Null değil ise koşullu getir 
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State= EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
