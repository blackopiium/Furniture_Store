using Furn_Store.Data.Helpers;
using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using Furn_Store.Data.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data.Data.EFCore
{
    public class ItemRepository : GenericRepository<Item, int>, IItemRepository

    {
        /*private readonly RepositoryContext _repositoryContext;*/
        private readonly ISortHepler<Item> _sortHelper;
        public ItemRepository(RepositoryContext context, ISortHepler<Item> sortHelper)
             : base(context)
        {
            /* _repositoryContext = context;*/
            _sortHelper = sortHelper;
        }
        public async Task<PagedList<Item>> GetAllPagesFiltered(ItemParameters parameters)
        {
            var items = FindByCondition(x => x.Price >= parameters.minPrice && x.Price <= parameters.maxPrice);
            items = _sortHelper.ApplySort(items, parameters);
            return await PagedList<Item>.ToPagedList(items, parameters.PageNumber, parameters.PageSize);
        }

    }
}
