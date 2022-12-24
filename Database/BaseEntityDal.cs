using CoffeShopManagement.Database.Interfaces;
using CoffeShopManagement.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace CoffeShopManagement.Database
{
    //BaseEntityDal'dan kalıtım alan class T gönderecek ve bizde onu IEntityTemplate'ye göndereceğiz
    //TContext ile bağlantı çeşidinden bağımsız hale geldik
    internal class BaseEntityDal<TEntity, TContext> : IEntityTemplate<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        protected TContext _context;
        public TEntity Add(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Added;
            _context.SaveChanges();
            return entity;
        }

        public TEntity AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
            _context.SaveChanges();
            return entity;
        }

        public void ConnectToInstance(DbContext context)
        {
            _context = (TContext)context;
        }

        public DbContext CreateInstance(bool newContext = false)
        {
            return newContext == true ? _context = new TContext() : _context;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Deleted;
            _context.SaveChanges();
            return entity;
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filter));
            _context.SaveChanges();
        }

        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Any(filter);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
