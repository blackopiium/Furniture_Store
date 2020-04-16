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
    public class FactoryService : IFactoryService
    {
        IUnitOfWork _uow { get; set; }
       private readonly IMapper _mapper;
        public FactoryService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FactoryDTO>> GetAllFactories()
        {
            var x = await _uow.Factories.GetAll();
            List<FactoryDTO> result = new List<FactoryDTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Factory, FactoryDTO>(element));
            return result;

        }
        public async Task<FactoryDTO> GetFactory(int id)
        {
            var x = await _uow.Factories.GetById(id);
            return _mapper.Map<Factory, FactoryDTO>(x);

        }
        public async Task<int> AddFactory(FactoryDTO factory)
        {
            var x = _mapper.Map<FactoryDTO, Factory>(factory);
            return await _uow.Factories.Add(x);
        }
        public async Task UpdateFactory(FactoryDTO factory)
        {
            var x = _mapper.Map<FactoryDTO, Factory>(factory);
            await _uow.Factories.Update(x);
        }
        public async Task DeleteFactory(int id)
        {
            await _uow.Factories.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}