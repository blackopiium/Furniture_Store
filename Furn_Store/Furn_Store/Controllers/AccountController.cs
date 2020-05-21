using AutoMapper;
using Furniture_Store.Data.Models;
using Furn_Store.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Business.DTO.Identity;

namespace Furniture_Store.Controllers
{

        [Authorize(AuthenticationSchemes = "Bearer")]
        [Route("api/[controller]")]
        public class AccountController : Controller
        {
        private readonly IAccountService _service;
            public AccountController(IAccountService accountService)
            {
                _service = accountService;
            }

            [HttpPost]
            [AllowAnonymous]
            [Route("register")]
            public async Task<IActionResult> Register([FromBody]RegisterDTO myUser)
            {
                return Ok(await _service.Register(myUser));
            }

            [HttpGet]
            [AllowAnonymous]
            [Route("Login")]
            public async Task<IActionResult> Login([FromBody]LoginDTO myUser)
            {
                return Ok(await _service.Login(myUser));
            }
            [HttpGet]
            [Route("Exit")]
            public async Task<IActionResult> Exit()
            {
                return Ok(await _service.Exit());
            }
            [HttpGet]
            [Route("Create")]
            public async Task<IActionResult> Create([FromBody]MyUserDTO myUser)
            {
                return Ok(await _service.Create(myUser));
            }
            
            [HttpGet]
            public async Task<IActionResult> List()
            {
                return Ok(await _service.List());
            }
        }

}
