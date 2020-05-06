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
            CreateMap<Item, ItemDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Factory, FactoryDTO>().ReverseMap();
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Order_Items, Order_Items_DTO>().ReverseMap();
            CreateMap<Charachteristics_Item, Charachteristic_Item_DTO>().ReverseMap();
            
        }
    }
}
