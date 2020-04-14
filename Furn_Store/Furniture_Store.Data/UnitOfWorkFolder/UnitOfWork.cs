using Furniture_Store.Data;
using Furniture_Store.Data.Data.EFCore;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Interfaces;
using Furniture_Store.Interfaces;
using Furniture_Store.Models;
using Furniture_Store.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.UnitOfWorkFolder
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
            Order_Items = new Order_ItemsRepository(_repositoryContext);
            Charachteristics_Items = new Charachteristics_ItemRepository(_repositoryContext);
        }
        public IItemRepository Items { get;  }
        public ICategoryRepository Categories { get; }
        public IFactoryRepository Factories { get; }
        public IOrderRepository Orders { get;  }
        public IClientRepository Clients { get;  }
        public IOrder_Items_Repository Order_Items { get; }
        public ICharachteristics_ItemRepository Charachteristics_Items { get; }
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
