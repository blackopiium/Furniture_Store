using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Parameters;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furniture_Store.Controllers
{
    public class ItemController : Controller
    {
        IItemService _service;
        public ItemController(IItemService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("api/Item")]
        public async Task<IActionResult> GetCategories([FromQuery] ItemParameters parameters)
        {
            try
            {
                return Ok(await _service.GetItemPagesFiltered(parameters));
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Route("item/{Id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                return Ok(await _service.GetItem(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Item")]
        public async Task<IActionResult> AddCategory([FromBody] ItemDTO model)
        {
            try
            {
                await _service.AddItem(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete]
        [Route("DeleteItem")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _service.DeleteItem(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("updateItem")]
        public async Task<IActionResult> UpdateCategory([FromBody]ItemDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.UpdateItem(model);

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