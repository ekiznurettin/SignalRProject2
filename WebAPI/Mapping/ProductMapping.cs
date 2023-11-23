using AutoMapper;
using EntityLayer.Dtos.FeatureDtos;
using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
        }
    }
}
