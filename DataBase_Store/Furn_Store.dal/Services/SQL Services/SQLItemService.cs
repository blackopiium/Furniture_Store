using System;
using System.Collections.Generic;
using System.Text;
using Furnit.Entities;
using Furnit.Interfaces;
using Furnit.Interfaces.SQLInterfaces.ISQLServices;

namespace Furnit.Services.SQL_Services
{
    public class SQLItemService : ISQLItemServices
    {
       public ISQLUnitOfWork _SqlsqlunitOfWork;
        public SQLItemService(ISQLUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<Items> GetItems()
        {
            return _SqlsqlunitOfWork.SQLItemsRepository.GetItems();
        }
       
    }
}

