using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Furniture_Store.Data;
using Furniture_Store.Models;

namespace Furniture_Store.Data.EFCore
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public RepositoryContext _context = null;
        public DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new RepositoryContext();
            table = _context.Set<T>();
        }

        public GenericRepository(RepositoryContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

    }
}
