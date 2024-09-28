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

        public CategoryController(ICategoryWriteService categoryWriteService)
        {
            _categoryWriteService = categoryWriteService;
        }

        [HttpPost]
        public async Task<Category> AddCategory([FromBody] AddCategoryRequest request)
        {
            Category cat= await _categoryWriteService.AddCategoryAsync(request);

            return cat;
           
        }
        [HttpPut]
        public async Task<Category> UpdateCategory([FromBody] UpdateCategoryRequest request)
        {
            Category response=await _categoryWriteService.UpdateCategoryAsync(request);
            return response;
        }
        [HttpDelete]
        public async Task<Category> DeleteCategory([FromBody] DeleteCategoryRequest request)
        {
            Category response = await _categoryWriteService.DeleteCategoryByIdAsync(request.Id);
            return response;
        }
        [HttpPost("AddRAnge")]
        public async Task<List<Category>> AddRangeCategory([FromBody] IEnumerable<AddRangeCategoryRequest> request)
        {
            var response = await _categoryWriteService.AddRangeCategoriesAsync(request);
            return response;
        }
        
    }
}
