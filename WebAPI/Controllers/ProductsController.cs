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
        [HttpDelete]
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
        [HttpGet("getProduct")]
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
