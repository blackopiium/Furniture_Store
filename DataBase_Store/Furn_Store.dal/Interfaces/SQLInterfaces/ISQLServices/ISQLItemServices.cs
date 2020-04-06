using System;
using System.Collections.Generic;
using System.Text;
using Furnit.Entities;
using Furnit.Interfaces.EntityInterfaces;
namespace Furnit.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLItemServices
    {
        IEnumerable<Items> GetItems();
        /*int AddItems(Items items);
        int DeleteItem(int id);
        IEnumerable<Items> GetItemById(int id);
        int UpdateItem(Items items);*/
    }
}
