using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
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
        ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Category")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                return Ok(await _service.GetAllCategories());
            }
            catch
            {
                return StatusCode(404);
            }

        }
        [HttpGet]
        [Route("Category/{Id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                return Ok(await _service.GetCategory(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Category")]
        public async Task<IActionResult> AddCategory([FromBody] CategoryDTO model)
        {
            try
            {
                await _service.AddCategory(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete]
        [Route("Category/{Id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _service.DeleteCategory(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory([FromBody]CategoryDTO model)
        {
            try
            {
                await _service.UpdateCategory(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
