using Furniture_Store.Interfaces;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _repository;
        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Order")]
        public IEnumerable<Order> GetAllOrders() => _repository.GetAll();
        [HttpGet]
        [Route("order/{Id}")]
        public Order GetOrderById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Order")]
        public void AddOrder(Order order) => _repository.Insert(order);
        [HttpDelete]
        [Route("order/{Id}")]
        public void DeleteOrder(int id) => _repository.Delete(id);
    }
}
