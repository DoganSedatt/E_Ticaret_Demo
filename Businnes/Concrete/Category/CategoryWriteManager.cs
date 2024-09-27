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

        public async Task<List<Category>> AddRangeCategoriesAsync(IEnumerable<Category> categories)
        {

            throw new NotImplementedException();
        }

        public async Task<Category> DeleteCategoryAsync(Category category)
        {
            var result = _categoryWriteRepository.DeleteWithModelAsync(category);
            if (result) return category;

            return null;
        }

        public async Task<Category> DeleteCategoryByIdAsync(Guid id)
        {
            Category? response = await _categoryReadRepository.GetByIdAsync(id);
            var category = await _categoryWriteRepository.DeleteWithIdAsync(id);
            if (response != null) return response;

            return null;

        }

        public async Task<Category> UpdateCategoryAsync(UpdateCategoryRequest category)
        {
            Category? find = await _categoryReadRepository.GetSingleAsync(c => c.Id == category.Id);

            if (find != null)
            {
                find.CategoryName = category.CategoryName;
                 _categoryWriteRepository.Update(find);
                return find;
            }

            return null;

        }
    }
}
