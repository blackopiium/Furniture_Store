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
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await _repository.GetAll();
                if (categories == null)
                {
                    return NotFound();
                }

                return Ok(categories);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("Category/{Id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            try
            {
                var category= await _repository.GetById(id);

                if (category == null)
                {
                    return NotFound();
                }

                return Ok(category);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("Category")]
        public async Task<IActionResult> AddCategory([FromBody] Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Add(model);
                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName== "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                }
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("Category/{Id}")]
        public async Task<IActionResult> DeleteCategory([FromBody]Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Remove(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory([FromBody]Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Update(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}
