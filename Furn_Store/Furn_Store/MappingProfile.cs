using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Furniture_Store.Data.Models;
using Furn_Store.ViewModels;
using Furniture_Store.Business.DTO;
using Furniture_Store.Models;

namespace Furniture_Store
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<ItemDTO, Item>();
        }
    }
}
