using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Reflection;
using Furnit.Interfaces;
using Furnit.Interfaces.EntityInterfaces;
using Dapper;
using Furnit.Entities;

namespace Furnit.Repositories
{
    public class GenericRepository<TItems, TId_Items> : IGenericRepository<TItems, TId_Items> where TItems : IItems<TId_Items>
    {
        protected IConnectionFactory _connectionFactory;
       /* private readonly string _tableName;
        private readonly bool _isSoftDelete;*/

        public GenericRepository(IConnectionFactory connectionFactory/*, string tableName, bool isSoftDelete*/)
        {
            _connectionFactory = connectionFactory;
            /*_tableName = tableName;
            _isSoftDelete = isSoftDelete;*/
        }
        public IEnumerable<TItems> GetItems()
        {
            List<TItems> itemsList = new List<TItems>();
            using (var db = _connectionFactory.GetSqlConnection)
            {
                itemsList = db.Query<TItems>("readRows").ToList();

            }
            return itemsList;

        }
        /*public IEnumerable<TItems> GetItemById(TId id)
        {
            List<TItems> itemsListbyId = new List<TItems>();
            if (id == null)
                return itemsListbyId;
            using (var db = _connectionFactory.GetSqlConnection)
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id_Item", id);
                itemsListbyId = db.Query<TItems>("readRowbyId", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();

            }
            return itemsListbyId;
        }
*/
        
        }
   
       
    }

