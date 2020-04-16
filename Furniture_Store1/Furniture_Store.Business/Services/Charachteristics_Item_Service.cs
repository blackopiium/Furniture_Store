using AutoMapper;
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
    public class Charachteristics_Item_Service : ICharachteristics_Service
    {
        IUnitOfWork _uow { get; set; }
        private readonly IMapper _mapper;
        public Charachteristics_Item_Service(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Charachteristic_Item_DTO>> GetAllCharc()
        {
            var x = await _uow.Charachteristics_Items.GetAll();
            List<Charachteristic_Item_DTO> result = new List<Charachteristic_Item_DTO>();
            foreach (var element in x)
                result.Add(_mapper.Map<Charachteristics_Item, Charachteristic_Item_DTO>(element));
            return result;

        }
        public async Task<Charachteristic_Item_DTO> GetCharc(int id)
        {
            var x = await _uow.Charachteristics_Items.GetById(id);
            return _mapper.Map<Charachteristics_Item, Charachteristic_Item_DTO>(x);

        }
        public async Task<int> AddCharc(Charachteristic_Item_DTO charachteristics_Item)
        {
            var x = _mapper.Map<Charachteristic_Item_DTO,  Charachteristics_Item>(charachteristics_Item);
            return await _uow.Charachteristics_Items.Add(x);
        }
        public async Task UpdateCharc(Charachteristic_Item_DTO charachteristic_Item_)
        {
            var x = _mapper.Map<Charachteristic_Item_DTO, Charachteristics_Item>(charachteristic_Item_);
            await _uow.Charachteristics_Items.Update(x);
        }
        public async Task DeleteCharc(int id)
        {
            await _uow.Charachteristics_Items.Remove(id);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
     }
}
