using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Data;

namespace Furniture_Store.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);

        Task<IEnumerable<T>> GetAll();
    }
}
