using Furniture_Store.Data;
using Furniture_Store.Data.Data.EFCore;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Helpers;
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
        private readonly RepositoryContext _context;
        private readonly IItemRepository _item;
        private readonly ICategoryRepository _category;
        private readonly IFactoryRepository _factory;
        private readonly IClientRepository _client;
        private readonly ICharachteristics_ItemRepository _charach;
        private readonly IOrderRepository _orders;
        private readonly IOrder_Items_Repository _ord_it;
        private readonly ISortHepler<Item> _itemSortHepler;
        public UnitOfWork(
            RepositoryContext context, 
            IItemRepository item,
            ICategoryRepository category,
            IFactoryRepository factory,
            IClientRepository client,
            ICharachteristics_ItemRepository charach, 
            IOrderRepository orders,
            IOrder_Items_Repository ord_it, 
            ISortHepler<Item> itemSortHelper)
        {
            _context = context;
            _item = item;
            _category = category;
            _factory = factory;
            _client = client;
            _charach = charach;
            _orders = orders;
            _ord_it = ord_it;
            _itemSortHepler = itemSortHelper;
        }
        public IItemRepository Items
        {
            get
            {
                return _item;
            }
        }
        public ICategoryRepository Categories
        {
            get
            {
                return _category;
            }
        }
        public IFactoryRepository Factories
        {
            get
            {
                return _factory;
            }
        }
        public IClientRepository Clients
        {
            get
            {
                return _client;
            }
        }
        public IOrderRepository Orders
        {
            get
            {
                return _orders;
            }
        }
        public IOrder_Items_Repository Order_Items
        {
            get
            {
                return _ord_it;
            }
        }
        public ICharachteristics_ItemRepository Charachteristics_Items
        {
            get
            {
                return _charach;
            }
        }

      public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
