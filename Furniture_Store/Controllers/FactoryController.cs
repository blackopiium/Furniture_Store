using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Models;
using Furniture_Store.Data.EFCore;

namespace Furniture_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : DBController<Factory, EFCoreFactoryRepository>
    {
        public FactoryController(EFCoreFactoryRepository repository) : base(repository)
        {

        }
    }
}