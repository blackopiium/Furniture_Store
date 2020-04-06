using Furniture_Store.Data.EFCore;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class FactoryController : Controller
    {
        private readonly IFactoryRepository _repository;
        public FactoryController(IFactoryRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Factory")]
        public IEnumerable<Factory> GetAllItems() => _repository.GetAll();
        [HttpGet]
        [Route("Factory/{Id}")]
        public Factory GetFactoryById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Factory")]
        public void AddFactory(Factory factory) => _repository.Insert(factory);
        [HttpDelete]
        [Route("Factory/{Id}")]
        public void DeleteFactory(int id) => _repository.Delete(id);

    }
}
