using AutoMapper;
using Furniture_Store.Business.DTO.Identity;
using Furniture_Store.Data.Models;
using Furniture_Store.UnitOfWorkFolder;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Furniture_Store.Business.Interfaces;

namespace Furniture_Store.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AccountService(IUnitOfWork uow, IMapper mapper, IConfiguration configuration)
        {
           _uow = uow;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<string> Register(RegisterDTO myUser)
        {
            if (myUser.Password != myUser.PasswordConfirm)
                return "Passwords aren't equal";

            MyUser user = new MyUser { Email = myUser.Email, UserName = myUser.UserName };
            var result = await _uow.userManager.CreateAsync(user, myUser.Password);
            if (result.Succeeded)
            {
                await _uow.userManager.AddToRoleAsync(user, "user");
                return "Registration is suceeded";
            }
            else
            {
                string ErrorMessage = "";
                foreach (var error in result.Errors)
                {
                    ErrorMessage += error.Description + "\n";
                }
                return ErrorMessage;
            }
        }
        public async Task<string> Create(MyUserDTO myUser)
        {
            MyUser user = new MyUser { Email = myUser.Email, UserName = myUser.UserName };
            var result = await _uow.userManager.CreateAsync(user, myUser.Password);
            if (result.Succeeded)
            {
                await _uow.userManager.AddToRoleAsync(user, "User");
                return "User is registered";
            }
            else
            {
                string ErrorMessage = "";
                foreach (var error in result.Errors)
                {
                    ErrorMessage += error.Description + "\n";
                }
                return ErrorMessage;
            }
        }
        public async Task<object> Login(LoginDTO myUser)
        {
            MyUser user = await _uow.userManager.FindByNameAsync(myUser.UserName);
            if (user != null)
            {
                var result = await _uow.signInManager.PasswordSignInAsync(myUser.UserName, myUser.Password, myUser.RememberMe, false);
                if (result.Succeeded)
                {
                    return CreateToken(user);
                }
                else
                {
                    return "Invalid password or username";
                }
            }
            return "User doesn't exist";
        }
        public async Task<string> Exit()
        {
            await _uow.signInManager.SignOutAsync();
            return "Exited";
        }
        public async Task<List<MyUser>> List()
        {
            return await _uow.userManager.Users.ToListAsync();
        }
        private object CreateToken(MyUser myUser)
        {

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, myUser.UserName),
                new Claim(ClaimTypes.Email, myUser.Email)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddDays(double.Parse(_configuration["JwtExpiryInDays"]));
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["JwtIssuer"],
                audience: _configuration["JwtAudience"],
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expiration,
                signingCredentials: creds);
            return new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };
        }
    }
}
