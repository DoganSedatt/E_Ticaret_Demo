using Businnes;
using Businnes.Requests.Category;
using DataAccess.Repository;
using Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace E_Ticaret_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryWriteService _categoryWriteService;
        private readonly ICategoryReadService _categoryReadService;
        public CategoryController(ICategoryWriteService categoryWriteService, ICategoryReadService categoryReadService)
        {
            _categoryWriteService = categoryWriteService;
            _categoryReadService = categoryReadService;
        }

        [HttpPost]
        public async Task<Category> AddCategory([FromBody] AddCategoryRequest request)
        {
            Category cat = await _categoryWriteService.AddCategoryAsync(request);

            return cat;

        }
        [HttpPut]
        public async Task<Category> UpdateCategory([FromBody] UpdateCategoryRequest request)
        {
            Category response = await _categoryWriteService.UpdateCategoryAsync(request);
            return response;
        }
        [HttpDelete("Id")]
        public async Task<Category> DeleteCategory([FromBody] DeleteCategoryRequest request)
        {
            Category response = await _categoryWriteService.DeleteCategoryByIdAsync(request.Id);
            return response;
        }
        [HttpDelete]
        public async Task<Category> DeleteByCategory([FromBody] DeleteByCategoryRequest request)
        {
            Category response = await _categoryWriteService.DeleteCategoryAsync(request);
            return response;
        }

        [HttpPost("AddRAnge")]
        public async Task<List<Category>> AddRangeCategory([FromBody] IEnumerable<AddRangeCategoryRequest> request)
        {
            var response = await _categoryWriteService.AddRangeCategoriesAsync(request);
            return response;
        }
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var response = await _categoryReadService.GetCategoriesAsync();
            return response;
        }
        [HttpGet("where")]
        public async Task<IEnumerable<Category>> GetWhereCategories()
        {
            var response = await _categoryReadService.GetWhereCategoriesAsync();

            return response;
        }

        [HttpGet("id")]
        public async Task<Category> GetCategoryById([FromQuery] Guid id)
        {
            var response=await _categoryReadService.GetSingleByIdCategoryAsync(id);
            return response;
        }
    }
}
