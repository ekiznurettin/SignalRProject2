using AutoMapper;
using EntityLayer.Dtos.SocialMediaDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, SocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
        }
    }
}
