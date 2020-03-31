using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Models;
using Furniture_Store.Data.EFCore;

namespace Furniture_Store.Data.EFCore
{
    public class EFCoreItemRepository : EFCoreRepository<Item, RepositoryContext>
    {
        public EFCoreItemRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
