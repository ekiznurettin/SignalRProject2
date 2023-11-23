using AutoMapper;
using EntityLayer.Dtos.AboutDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
        }
    }
}
