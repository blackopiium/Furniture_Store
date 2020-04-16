using Furniture_Store.Business.DTO;
using Furniture_Store.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store.Business.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemDTO>> GetAllItems();
        Task<ItemDTO> GetItem(int id);
        Task UpdateItem(ItemDTO item);
        Task<int> AddItem(ItemDTO item);
        Task DeleteItem(int id);
        void Dispose();
    }
}
