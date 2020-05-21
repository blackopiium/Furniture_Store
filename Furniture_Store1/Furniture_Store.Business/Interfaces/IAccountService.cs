using Furniture_Store.Business.DTO.Identity;
using Furniture_Store.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store.Business.Interfaces
{
    public interface IAccountService
    {
        public Task<string> Register(RegisterDTO myUser);
        public Task<string> Create(MyUserDTO myUser);
        public Task<object> Login(LoginDTO myUser);
        public Task<string> Exit();
        public Task<List<MyUser>> List();
    }
}
