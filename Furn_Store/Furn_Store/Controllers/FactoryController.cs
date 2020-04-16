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
        [Route("Factory/{Id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            try
            {
                var category = await _repository.GetById(id);

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
        [Route("Factory")]
        public async Task<IActionResult> AddCategory([FromBody] Factory model)
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
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                }
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("Factory/{Id}")]
        public async Task<IActionResult> DeleteCategory([FromBody]Factory model)
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
        public async Task<IActionResult> UpdateCategory([FromBody]Factory model)
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
