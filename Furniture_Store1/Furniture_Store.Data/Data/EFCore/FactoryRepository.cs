using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Data.EFCore
{
    public class FactoryRepository : GenericRepository<Factory>, IFactoryRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public FactoryRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
