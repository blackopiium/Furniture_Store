using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Furniture_Store.Data;
using Microsoft.AspNetCore.Mvc;
using Furniture_Store.Models;
using Furniture_Store.Data.EFCore;

namespace Furniture_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : DBController<Item, EFCoreItemRepository>
    {
        public ItemController(EFCoreItemRepository repository) : base(repository)
        {

        }

    }
}

