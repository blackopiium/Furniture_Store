using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Data.EFCore
{
    public class FactoryRepository : GenericRepository<Factory, int>, IFactoryRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public FactoryRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
