using AutoMapper;
using EntityLayer.Dtos.AboutDtos;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<Basket, ResultBasketDto>().ReverseMap();
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
            CreateMap<Basket, UpdateBasketDto>().ReverseMap();
            CreateMap<Basket, GetBasketDto>().ReverseMap();
        }
    }
}
