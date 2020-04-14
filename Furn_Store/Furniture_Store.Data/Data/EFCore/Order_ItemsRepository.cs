using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Interfaces;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Data.Data.EFCore
{
    public class Order_ItemsRepository : GenericRepository<Order_Items>, IOrder_Items_Repository
    {
        private readonly RepositoryContext _repositoryContext;
        public Order_ItemsRepository(RepositoryContext context)
            : base(context)
        {
            _repositoryContext = context;
        }
    }
}
