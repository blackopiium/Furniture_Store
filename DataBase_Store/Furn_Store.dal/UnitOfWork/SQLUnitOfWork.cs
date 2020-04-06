using System;
using System.Collections.Generic;
using System.Text;
using Furnit.Interfaces;
using Furnit.Interfaces.SQLInterfaces.ISQLRepositories;

namespace Furnit.UnitOfWork 
{
    public class SQLsqlUnitOfWork : ISQLUnitOfWork
    {
        private readonly ISQLItemsRepository _sqlItemsRepository;
        public SQLsqlUnitOfWork(ISQLItemsRepository sqlItemsRepository)
        {
            _sqlItemsRepository = sqlItemsRepository;
        }
        public ISQLItemsRepository SQLItemsRepository
        {
            get
            {
                return _sqlItemsRepository;
            }
        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
    
}
