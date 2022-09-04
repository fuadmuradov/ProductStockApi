using Microsoft.EntityFrameworkCore;
using ProductStock.Core.IRepositories;
using ProductStock.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly StockDbContext context;
        public Repository(StockDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
           await context.Set<TEntity>().AddAsync(entity);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> exp)
        {
            var query = context.Set<TEntity>().AsQueryable();
           
            return query.Where(exp);
        }

        public  Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp)
        {
            var query = context.Set<TEntity>().AsQueryable();
           
            return query.FirstOrDefaultAsync(exp);
        }

        public Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> exp)
        {
            var query = context.Set<TEntity>().AsQueryable();

            return query.AnyAsync(exp);
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public int SaveDb()
        {
            return context.SaveChanges();
        }

        public Task<int> SaveDbAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}
