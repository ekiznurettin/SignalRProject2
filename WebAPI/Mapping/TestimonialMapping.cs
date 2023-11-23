using AutoMapper;
using EntityLayer.Dtos.TestimonialDtos;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, TestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap< Testimonial, GetTestimonialDto>().ReverseMap();
        }
    }
}
