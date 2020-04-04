using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Models;
using Furniture_Store.Data.EFCore;

namespace Furniture_Store.Data.EFCore
{
    public interface IItemRepository : IRepository<Item>
    {
    }
}
