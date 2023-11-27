using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.ProductDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet("productCount")]
        public  IActionResult ProductCount()
        {
            return Ok(_productService.TGetProductCount());
        }

        [HttpGet("productAvgPrice")]
        public IActionResult ProductAvgPrice()
        {
            return Ok(_productService.TGetProductAvgPrice());
        }

        [HttpGet("productPriceByElektronik")]
        public IActionResult ProductPriceByElektronik()
        {
            return Ok(_productService.TGetProductPriceByElektronik());
        }


        [HttpGet("productNamebyMaxPrice")]
        public IActionResult ProductNamebyMaxPrice()
        {
            return Ok(_productService.TGetProductNameByMaxPrice());
        }

        [HttpGet("productNamebyMinPrice")]
        public IActionResult ProductNamebyMinPrice()
        {
            return Ok(_productService.TGetProductNameByMinPrice());
        }

        [HttpGet("productCountByElektronik")]
        public IActionResult ProductCountByElektronik()
        {
            return Ok(_productService.TGetProductCountByCategoryName("Elektronik"));
        }
        [HttpGet("productCountByGiyim")]
        public IActionResult ProductCountByGiyim()
        {
            return Ok(_productService.TGetProductCountByCategoryName("Giyim"));
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ProductDto>>(_productService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            _productService.TAdd(product);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(product);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpGet("productListwithCategory")]
        public IActionResult ProductListwithCategory()
        {
            var values = _productService.TGetProductsWithCategories();
            return Ok(values);
        }
    }
}
