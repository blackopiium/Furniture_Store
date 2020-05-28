using Furn_Store.Business.DTO.Identity;
using Furn_Store.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _service;
        public AccountController(IAccountService accountService)
        {
            _service = accountService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Microsoft.AspNetCore.Mvc.Route("register")]
        public async Task<IActionResult> Register([FromBody]RegisterDTO myUser)
        {
            return Ok(await _service.Register(myUser));
        }

        //[HttpGet]
        //[AllowAnonymous]
        //[Route("Login")]
        //public async Task<IActionResult> Login([FromBody]LoginDTO myUser)
        //{
        //    return Ok(await _service.Login(myUser));
        //}
        //[HttpGet]
        //[Route("Exit")]
        //public async Task<IActionResult> Exit()
        //{
        //    return Ok(await _service.Exit());
        //}
        //[HttpGet]
        //[Route("Create")]
        //public async Task<IActionResult> Create([FromBody]MyUserDTO myUser)
        //{
        //    return Ok(await _service.Create(myUser));
        //}

        //[HttpGet]
        //public async Task<IActionResult> List()
        //{
        //    return Ok(await _service.List());
        //}
    }
}
