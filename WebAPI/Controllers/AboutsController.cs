using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.AboutDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutservice _aboutservice;
        private readonly IMapper _mapper;

        public AboutsController(IAboutservice aboutservice, IMapper mapper)
        {
            _aboutservice = aboutservice;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutservice.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var about = _mapper.Map<About>(createAboutDto);
            _aboutservice.TAdd(about);
            return Ok("Ekleme işlemi başarıyla gerçekleşti");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutservice.TGetById(id);
            _aboutservice.TDelete(value);
            return Ok("Silme işlemi başarıyla gerçekleşti");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var about = _mapper.Map<About>(updateAboutDto);
            _aboutservice.TDelete(about);
            return Ok("Güncelleme işlemi başarıyla gerçekleşti");
        }
        [HttpGet("getAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutservice.TGetById(id);
            return Ok(value);
        }
    }
}
