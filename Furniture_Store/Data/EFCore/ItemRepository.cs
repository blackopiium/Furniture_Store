using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Data.EFCore
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository

    {
        private readonly RepositoryContext _repositoryContext;
        public ItemRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }

    }
}
