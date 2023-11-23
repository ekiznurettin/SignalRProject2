using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.FeatureDtos;
using EntityLayer.Dtos.TestimonialDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _mapper.Map<List<FeatureDto>>(_testimonialService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TAdd(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var feature = _testimonialService.TGetById(id);
            _testimonialService.TDelete(feature);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }
        [HttpGet("getTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
