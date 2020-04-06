using Furnit.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furnit.Interfaces
{
   public interface IGenericRepository<TItems, TId_Item> where TItems :IItems<TId_Item>
    {
        IEnumerable<TItems> GetItems();
        /*IEnumerable<TItems> GetItemById(TId_item id);
        int AddItems(TItems items);
        int DeleteItem(TId id);
        int UpdateItem(TItems items);*/
    }
}
