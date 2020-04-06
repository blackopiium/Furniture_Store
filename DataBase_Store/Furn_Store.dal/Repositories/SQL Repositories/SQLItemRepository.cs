using System;
using System.Collections.Generic;
using System.Text;
using Furnit.Entities;
using Furnit.Interfaces;
using System.Configuration;
using Furnit.Interfaces.SQLInterfaces.ISQLRepositories;

namespace Furnit.Repositories.SQL_Repositories
{
    public class SQLItemRepository : GenericRepository<Items, int>, ISQLItemsRepository
    {
        /*private static readonly string _tableName = "Items";
        private static readonly bool _isSoftDelete = true;*/
        public SQLItemRepository(IConnectionFactory connectionFactory, bool IsTest) : base(connectionFactory /*_tableName, _isSoftDelete*/)
        {
            if (!IsTest)
                connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}
