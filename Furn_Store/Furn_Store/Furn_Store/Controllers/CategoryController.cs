using Furniture_Store.Data.EFCore;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;
        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Category")]
        public IEnumerable<Category> GetAllItems() => _repository.GetAll();
        [HttpGet]
        [Route("Category/{Id}")]
        public Category GetCategoryById(int id) => _repository.GetById(id);
        [HttpPost]
        [Route("Category")]
        public void AddCategory(Category category) => _repository.Insert(category);
        [HttpDelete]
        [Route("Category/{Id}")]
        public void DeleteCategory(int id) => _repository.Delete(id);
    }
}
