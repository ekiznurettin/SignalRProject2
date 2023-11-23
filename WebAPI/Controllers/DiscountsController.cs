using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.ContactDtos;
using EntityLayer.Dtos.DiscountDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountsController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<DiscountDto>>(_discountService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            var discount = _mapper.Map<Discount>(createDiscountDto);
            _discountService.TAdd(discount);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var category = _discountService.TGetById(id);
            _discountService.TDelete(category);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateDiscountDto updateDiscountDto)
        {
            var discount = _mapper.Map<Discount>(updateDiscountDto);
            _discountService.TUpdate(discount);
            return Ok();
        }
        [HttpGet("getDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
    }
}
