using AutoMapper;
using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Models;
using Furniture_Store.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Furniture_Store.Business.Services
{
    public class ItemService : IItemService
    {
        IUnitOfWork _uow { get; set; }
        public ItemService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IEnumerable<ItemDTO> GetAllItems()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ItemDTO, ItemDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Item>, List<ItemDTO>>(_uow.Items.GetAll());
        }
        public ItemDTO GetItem(int? id)
        {
            if (id == null)
                throw new ValidationException("Cant find id of item");
            var item = _uow.Items.GetById(id.Value);
            if (item == null)
                throw new ValidationException("Cant find the item");
            return new ItemDTO { Id = item.Id, Name = item.Name, CategoryId = item.CategoryId, FactoryId = item.FactoryId, Price = item.Price };
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
