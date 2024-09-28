using Businnes.Requests.Category;
using DataAccess.Repository;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class CategoryWriteManager : ICategoryWriteService
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public CategoryWriteManager(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<Category> AddCategoryAsync(AddCategoryRequest request)
        {
            Category response = new Category { CategoryName = request.CategoryName };
            var result = await _categoryWriteRepository.AddAsync(response);
            if (result) return response;

            return null;
        }

        public async Task<List<Category>> AddRangeCategoriesAsync(IEnumerable<AddRangeCategoryRequest> categories)
        {

            var categoryEntities = categories.SelectMany(c => c.CategoryNames.Select(name => new Category { CategoryName = name })).ToList();

            
            var response = await _categoryWriteRepository.AddAsyncRange(categoryEntities);

            if (response)
            {
                
                return categoryEntities;
            }

            return null;
        }

        public async Task<Category> DeleteCategoryAsync(DeleteByCategoryRequest request)
        {
            Category response = await _categoryReadRepository.GetSingleAsync(c => c.CategoryName.Contains(request.CategoryName));
            
            
            var result = _categoryWriteRepository.DeleteWithModelAsync(response);
            if (result) return response;

            return null;
        }

        public async Task<Category> DeleteCategoryByIdAsync(Guid id)
        {
            Category? response = await _categoryReadRepository.GetByIdAsync(id);
            
            if (response != null) return response;

            return null;

        }

        public async Task<Category> UpdateCategoryAsync(UpdateCategoryRequest category)
        {
            Category? response = await _categoryReadRepository.GetSingleAsync(c => c.Id == category.Id);

            if (response != null)
            {
                response.CategoryName = category.CategoryName;
                 _categoryWriteRepository.Update(response);
                return response;
            }

            return null;

        }
    }
}
