using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Interfaces;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Data.Data.EFCore
{
    public class Charachteristics_ItemRepository : GenericRepository<Charachteristics_Item, int>, ICharachteristics_ItemRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public Charachteristics_ItemRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
