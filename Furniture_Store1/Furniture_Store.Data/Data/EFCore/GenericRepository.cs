using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Furniture_Store.Data;
using Furniture_Store.Models;
using Furniture_Store.UnitOfWorkFolder;

namespace Furniture_Store.Data.EFCore
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly RepositoryContext _context;
        public GenericRepository()
        {
            
        }
        public GenericRepository(RepositoryContext context)
        {
            _context = context;
            
        }
        public async Task Add(T entity)
        {
            // await Context.AddAsync(entity);
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
        public Task Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
       public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
