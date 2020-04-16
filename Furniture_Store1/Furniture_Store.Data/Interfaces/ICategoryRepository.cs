using Furniture_Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Data.EFCore
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
       
    }
}
