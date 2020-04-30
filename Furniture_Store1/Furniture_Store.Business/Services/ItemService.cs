using AutoMapper;
using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Data.Helpers;
using Furniture_Store.Data.Parameters;
using Furniture_Store.Models;
using Furniture_Store.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store.Business.Services
{
    public class ItemService : IItemService
    {
        IUnitOfWork _uow { get; set; }
       private IMapper _mapper;
        public ItemService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
       public async Task<IEnumerable<ItemDTO>> GetAllItems()
        {
            var x = await _uow.Items.GetAll();
            List<ItemDTO> result = new List<ItemDTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Item, ItemDTO>(element));
            return result;
            
        }
       public async Task <ItemDTO> GetItem(int id)
        {
            var x = await _uow.Items.GetById(id);
            return _mapper.Map<Item, ItemDTO>(x);

        }
        public async Task<int> AddItem(ItemDTO item)
        {
            var x = _mapper.Map<ItemDTO, Item>(item);
            return await _uow.Items.Add(x);
        }
        public async Task UpdateItem(ItemDTO item)
        {
            var x = _mapper.Map<ItemDTO, Item>(item);
            await _uow.Items.Update(x);
        }
        public async Task DeleteItem(int id)
        {
            await _uow.Items.Remove(id);
        }
        public async Task<PagedList<ItemDTO>> GetItemPagesFiltered(ItemParameters parameters)
        {
            var x = await _uow.Items.GetAllPagesFiltered(parameters);
            var result = _mapper.Map<PagedList<ItemDTO>>(x);
            return result;
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
