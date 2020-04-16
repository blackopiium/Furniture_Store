using Furniture_Store.Data.Interfaces;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class Charachteristics_Item_Controller : Controller
    {
        private readonly ICharachteristics_ItemRepository _repository;
        public Charachteristics_Item_Controller(ICharachteristics_ItemRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Charachteristics_Item")]
        public IEnumerable<Charachteristics_Item> GetAllChar() => _repository.GetAll();
        [HttpGet]
        [Route("Charachteristics_Item/{Id}")]
        public Charachteristics_Item GetCharById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Charachteristics_Item")]
        public void AddChar(Charachteristics_Item charachteristics_Item) => _repository.Insert(charachteristics_Item);
        [HttpDelete]
        [Route("Charachteristics_Item/{Id}")]
        public void DeleteChar(int id) => _repository.Delete(id);
    }
}
