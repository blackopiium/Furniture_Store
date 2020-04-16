﻿using Furniture_Store.Business.DTO;
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
    public class FactoryController : Controller
    {
        private readonly IFactoryService _service;
        public FactoryController(IFactoryService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Factory")]
        public async Task<IActionResult> GetFactories()
        {
            try
            {
                return Ok(await _service.GetAllFactories());
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpGet]
        [Route("Factory/{Id}")]
        public async Task<IActionResult> GetFactoryById(int id)
        {
            try
            {
                return Ok(await _service.GetFactory(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Factory")]
        public async Task<IActionResult> AddFactory([FromBody] FactoryDTO model)
        {
            try
            {
                await _service.AddFactory(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete]
        [Route("Factory/{Id}")]
        public async Task<IActionResult> DeleteFactory(int id)
        {
            try
            {
                await _service.DeleteFactory(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory([FromBody]FactoryDTO model)
        {
            try
            {
                await _service.UpdateFactory(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
