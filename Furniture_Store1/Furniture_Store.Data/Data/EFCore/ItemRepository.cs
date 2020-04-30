using Furniture_Store.Data.Helpers;
using Furniture_Store.Data.Parameters;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Furniture_Store.Data.EFCore
{
    public class ItemRepository : GenericRepository<Item, int>, IItemRepository

    {
        /*private readonly RepositoryContext _repositoryContext;*/
        private readonly ISortHepler<Item> _sortHelper;
       public ItemRepository(RepositoryContext context, ISortHepler<Item> sortHelper)
            : base(context)
        {
           /* _repositoryContext = context;*/
            _sortHelper=sortHelper;
        }
        public async Task<PagedList<Item>> GetAllPagesFiltered(ItemParameters parameters)
        {
            var items = FindByCondition(x => x.Price >= parameters.minPrice && x.Price <= parameters.maxPrice);
            items = _sortHelper.ApplySort(items, parameters);
            return await PagedList<Item>.ToPagedList(items, parameters.PageNumber, parameters.PageSize);
        }
        
    }
}
