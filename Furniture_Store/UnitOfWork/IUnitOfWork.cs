using Furniture_Store.Data.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Interfaces;
namespace Furniture_Store.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Items { get; } 
        ICategoryRepository Categories { get;  }
        IFactoryRepository Factories { get; }
        IClientRepository Clients { get;  }
        IOrderRepository Orders { get;  }
        void Save();

    }
}
