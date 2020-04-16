using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Data;

namespace Furniture_Store.Data
{
    public interface IRepository<T, TId> where T : class, IEntity<TId>
    {
        Task<T> GetById(TId id);
        Task<int> Add(T entity);
        Task Update(T entity);
        Task Remove(TId id);

        Task<IEnumerable<T>> GetAll();
    }
}
