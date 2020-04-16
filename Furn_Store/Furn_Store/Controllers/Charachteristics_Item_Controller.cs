﻿using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
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
       private readonly ICharachteristics_Service _service;
        public Charachteristics_Item_Controller(ICharachteristics_Service service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Charachteristics_Item")]
        public async Task<IActionResult> GetCharc()
        {
            try
            {
                return Ok(await _service.GetAllCharc());
            }
            catch
            {
                return StatusCode(404);
            }

        }
        [HttpGet]
        [Route("Charachteristics_Item/{Id}")]
        public async Task<IActionResult> GetCharcById(int id)
        {
            try
            {
                return Ok(await _service.GetCharc(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [HttpPost]
        [Route("Charachteristics_Item")]
        public async Task<IActionResult> AddCharc([FromBody] Charachteristic_Item_DTO model)
        {
            try
            {
                await _service.AddCharc(model);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [HttpDelete]
        [Route("Charachteristics_Item/{Id}")]
        public async Task<IActionResult> DeleteCharc(int id)
        {
            try
            {
                await _service.DeleteCharc(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        public async Task<IActionResult> UpdateCharc([FromBody]Charachteristic_Item_DTO model)
        {
            try
            {
                await _service.UpdateCharc(model);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}

