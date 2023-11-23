using AutoMapper;
using EntityLayer.Dtos.FeatureDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, FeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
        }
    }
}
