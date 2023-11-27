using AutoMapper;
using BusinessLayer.Abstract;
using EntityLayer.Dtos.CategoryDtos;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("categoryCount")]
        public IActionResult CategoryCount()
        {
            var values =  _categoryService.TGetCategoryCount();
            return Ok(values);
        }

        [HttpGet("activeCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            var values = _categoryService.TGetActiveCategoryCount();
            return Ok(values);
        }

        [HttpGet("passiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            var values = _categoryService.TGetPassiveCategoryCount();
            return Ok(values);
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<CategoryDto>>(_categoryService.TGetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TAdd(category);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _categoryService.TGetById(id);
            _categoryService.TDelete(category);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var category = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(category);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }
    }
}
