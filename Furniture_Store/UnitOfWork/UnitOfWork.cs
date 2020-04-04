using Furniture_Store.Data;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Interfaces;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext _repositoryContext;

        public UnitOfWork(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            Items = new ItemRepository(_repositoryContext);
            Categories = new CategoryRepository(_repositoryContext);
            Factories = new FactoryRepository(_repositoryContext);
            Orders = new OrderRepository(_repositoryContext);
            Clients = new CLientRepository(_repositoryContext);
        }
        public IItemRepository Items { get;  }
        public ICategoryRepository Categories { get; }
        public IFactoryRepository Factories { get; }
        public IOrderRepository Orders { get;  }
        public IClientRepository Clients { get;  }
        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
        public void Dispose()
        {
            _repositoryContext.Dispose();
        }
    }
}
