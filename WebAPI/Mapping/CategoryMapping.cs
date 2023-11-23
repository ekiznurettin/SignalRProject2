using AutoMapper;
using EntityLayer.Dtos.CategoryDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
        }
    }
}
