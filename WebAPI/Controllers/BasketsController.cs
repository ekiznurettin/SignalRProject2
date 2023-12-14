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
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public BasketsController(IBasketService basketService, IProductService productService, IMapper mapper)
        {
            _basketService = basketService;
            _productService = productService;
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
            var product = _productService.TGetById(createBasketDto.ProductId);
            basket.Price = product.Price;
            basket.Count = 1;
            basket.TotalPrice = 1 * product.Price;
            basket.MenuTableId = 4;
            _basketService.TAdd(basket);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Silindi");
        }
    }
}
