using Furniture_Store.Business.DTO;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Store.Business.Interfaces
{
    public interface IItemService
    {
        IEnumerable<ItemDTO> GetAllItems();
        ItemDTO GetItem(int? id);
        void Dispose();
    }
}
