using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Furnit.Interfaces;
using Furnit.Entities;
using Furnit.Interfaces.SQLInterfaces.ISQLServices;

namespace Furn_Store.Controllers
{
    public class ItemsController : Controller
    {
        #region Properties
        public ISQLItemServices _sqlItemsService;
        #endregion
        #region Constructors
        public ItemsController(ISQLItemServices sqlItemsService)
        {
            _sqlItemsService = sqlItemsService;
        }
        #endregion
        #region APIs
        // GET: Get all employees
        [Route("Items")]
        [HttpGet]
        public IEnumerable<Items> Get()
        {
            return _sqlItemsService.GetItems();
        }
        #endregion
    }
}

