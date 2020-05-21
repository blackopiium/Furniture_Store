using AutoMapper;
using Furniture_Store.Business.DTO.Identity;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Data.Models;
using Furniture_Store.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store.Business.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public RoleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task CreateRole(MyRoleDTO roleDTO)
        {
            var role = _mapper.Map<MyRoleDTO, MyRole>(roleDTO);
            await _uow.roleManager.CreateAsync(role);
        }
        public async Task AppointRole(string id, string role)
        {
            MyUser user = await _uow.userManager.FindByIdAsync(id);
            await _uow.userManager.AddToRoleAsync(user, role);
        }
        public async Task<IList<string>> GetAllRolesByUserId(string id)
        {
            MyUser user = await _uow.userManager.FindByIdAsync(id);
            IList<string> userRoles = null;
            if (user != null)
                userRoles = await _uow.userManager.GetRolesAsync(user);
            return userRoles;
        }
    }
}
