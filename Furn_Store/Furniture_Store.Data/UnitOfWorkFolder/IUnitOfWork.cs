using Furniture_Store.Data.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Interfaces;
using Furniture_Store.Data.Interfaces;

namespace Furniture_Store.UnitOfWorkFolder
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Items { get; }
        ICategoryRepository Categories { get; }
        IFactoryRepository Factories { get; }
        IClientRepository Clients { get; }
        IOrderRepository Orders { get; }
        ICharachteristics_ItemRepository Charachteristics_Items { get; }
        IOrder_Items_Repository Order_Items { get; }
       
        void Save();

    }
}
