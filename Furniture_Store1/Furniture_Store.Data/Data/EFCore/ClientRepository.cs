using Furniture_Store.Interfaces;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Data.EFCore
{
    public class CLientRepository : GenericRepository<Client, int>, IClientRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public CLientRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
