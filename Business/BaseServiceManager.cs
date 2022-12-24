using CoffeShopManagement.Database.Interfaces;
using CoffeShopManagement.Entities.Interfaces;
using CoffeShopManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CoffeShopManagement.Services
{
    internal class BaseServiceManager<TEntity, TDal> : IServiceTemplate<TEntity>
        where TEntity : class, IEntity, new()
        where TDal : class, IEntityTemplate<TEntity>, new()
    {
        protected TDal _dal = new TDal();
        public TEntity Add(TEntity entity)
        {
            return _dal.Add(entity);
        }

        public TEntity AddOrUpdate(TEntity entity)
        {
            return _dal.AddOrUpdate(entity);
        }

        public void ConnectToInstance(DbContext context)
        {
            _dal.ConnectToInstance(context);
        }

        public DbContext CreateInstance(bool newContext = false)
        {
            return _dal.CreateInstance(newContext);
        }

        public TEntity Delete(TEntity entity)
        {
            return _dal.Delete(entity);
        }

        public void Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            _dal.Delete(filter);
        }

        public void Dispose()
        {
            _dal.Dispose();
        }

        public bool Exist(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _dal.Exist(filter);
        }

        public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _dal.Get(filter);
        }

        public List<TEntity> List(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            return _dal.List(filter);
        }

        public TEntity Update(TEntity entity)
        {
            return _dal.Update(entity);
        }
    }
}
