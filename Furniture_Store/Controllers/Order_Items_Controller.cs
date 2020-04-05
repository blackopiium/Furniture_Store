using Furniture_Store.Data.Interfaces;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class Order_Items_Controller : Controller
    {
        private readonly IOrder_Items_Repository _repository;
        public Order_Items_Controller(IOrder_Items_Repository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Order_Items")]
        public IEnumerable<Order_Items> GetAllItems() => _repository.GetAll();
        [HttpGet]
        [Route("Order_Items/{Id}")]
        public Order_Items GetOrdItById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Order_Items")]
        public void AddOrdIt(Order_Items order_Items) => _repository.Insert(order_Items);
        [HttpDelete]
        [Route("Order_Items/{Id}")]
        public void DeleteOrdIt(int id) => _repository.Delete(id);
    }
}
