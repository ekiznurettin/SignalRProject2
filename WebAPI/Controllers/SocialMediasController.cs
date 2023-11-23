using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.FeatureDtos;
using EntityLayer.Dtos.SocialMediaDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _mapper.Map<List<FeatureDto>>(_socialMediaService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateSocialMediaDto createSocialMediaDto)
        {
            var socialMedia = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TAdd(socialMedia);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var feature = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(feature);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var socialMedia = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(socialMedia);
            return Ok();
        }
        [HttpGet("getSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
    }
}
