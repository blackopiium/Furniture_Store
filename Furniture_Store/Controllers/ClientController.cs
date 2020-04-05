using Furniture_Store.Interfaces;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _repository;
        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Client")]
        public IEnumerable<Client> GetAllClients() => _repository.GetAll();
        [HttpGet]
        [Route("Client/{Id}")]
        public Client GetClientById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Client")]
        public void AddClient(Client client) => _repository.Insert(client);
        [HttpDelete]
        [Route("client/{Id}")]
        public void DeleteClient(int id) => _repository.Delete(id);
    }
}
