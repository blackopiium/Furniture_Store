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
        [Route("Charachteristics_Item/{Id}")]
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
        [Route("Charachteristics_Item")]
        public async Task<IActionResult> AddCategory([FromBody] Charachteristics_Item model)
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
        [Route("Charachteristics_Item/{Id}")]
        public async Task<IActionResult> DeleteCategory([FromBody]Charachteristics_Item model)
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
        public async Task<IActionResult> UpdateCategory([FromBody]Charachteristics_Item model)
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
