using Furniture_Store.Data;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Interfaces
{
    public interface IOrderRepository :  IRepository<Order>
    {
    }
}
