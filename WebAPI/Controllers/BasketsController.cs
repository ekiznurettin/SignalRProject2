using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.BasketDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketsController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int tableId)
        {
            var values = _basketService.TGetBasketByMenuTableId(tableId);
            return Ok(values);
        }
        [HttpGet("BasketListByMenuTableWithProductName/{id}")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            return Ok(_basketService.TBasketListByMenuTableWithProductName(id));
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            var basket = _mapper.Map<Basket>(createBasketDto);
            _basketService.TAdd(basket);
            return Ok();
        }
    }
}
