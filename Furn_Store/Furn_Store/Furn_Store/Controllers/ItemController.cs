using Furniture_Store.Data.EFCore;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _repository;
        public ItemController(IItemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Item")]
        public IEnumerable<Item> GetAllItems() => _repository.GetAll();
        [HttpGet]
        [Route("item/{Id}")]
        public Item GetItemById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Item")]
        public void AddItem(Item item) => _repository.Insert(item);
        [HttpDelete]
        [Route("item/{Id}")]
        public void DeleteItem(int id) => _repository.Delete(id);
    }
}
