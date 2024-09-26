using Businnes.Requests.Category;
using DataAccess.Repository;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract.Product
{
    public class CategoryWriteManager : ICategoryWriteService
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoryWriteManager(ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<Category> AddCategoryAsync(AddCategoryRequest request)
        {
            Category response=new Category { CategoryName = request.CategoryName };
            var result= await _categoryWriteRepository.AddAsync(response);
            if (result) return response;

            return null;
        }

        public Task<List<Category>> AddRangeCategoriesAsync(IEnumerable<Category> categories)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
