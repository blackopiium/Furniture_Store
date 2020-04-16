﻿using AutoMapper;
using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Models;
using Furniture_Store.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store.Business.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoryDTO>> GetAllCategories()
        {
            var x = await _uow.Categories.GetAll();
            List<CategoryDTO> result = new List<CategoryDTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Category, CategoryDTO>(element));
            return result;

        }
        public async Task<CategoryDTO> GetCategory(int id)
        {
            var x = await _uow.Categories.GetById(id);
            return _mapper.Map<Category, CategoryDTO>(x);

        }
        public async Task<int> AddCategory(CategoryDTO category)
        {
            var x = _mapper.Map<CategoryDTO, Category>(category);
            return await _uow.Categories.Add(x);
        }
        public async Task UpdateCategory(CategoryDTO category)
        {
            var x = _mapper.Map<CategoryDTO, Category>(category);
            await _uow.Categories.Update(x);
        }
        public async Task DeleteCategory(int id)
        {
            await _uow.Categories.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
