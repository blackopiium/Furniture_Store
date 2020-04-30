using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Furniture_Store.Data;
using Furniture_Store.Models;
using Furniture_Store.Data.Interfaces;
using Furniture_Store.UnitOfWorkFolder;
using System.Linq.Expressions;

namespace Furniture_Store.Data.EFCore
{
    public class GenericRepository<T, TId> : IRepository<T, TId> where T : class, IEntity<TId>
    {
        protected RepositoryContext _context;
        protected DbSet<T> _dbSet;
        public GenericRepository(RepositoryContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            
        }
        public async Task<int> Add(T entity)
        {
            
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return 1;
        }
        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Remove(TId id)
        {
            T x = await _dbSet.FindAsync(id);
            _dbSet.Remove(x);
            await _context.SaveChangesAsync();
           
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
       public async Task<T> GetById(TId id)
        {
            return await _dbSet.FindAsync(id);
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
