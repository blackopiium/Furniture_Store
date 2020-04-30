using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Models;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Helpers;
using Furniture_Store.Data.Parameters;

namespace Furniture_Store.Data.EFCore
{
    public interface IItemRepository : IRepository<Item, int>
    {
        public Task<PagedList<Item>> GetAllPagesFiltered(ItemParameters parameters);
    }
}
