using DataAccess.Repository;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes
{
    public class CategoryReadManager : ICategoryReadService
    {
        private readonly ICategoryReadRepository _categoryReadRepository;

        public CategoryReadManager(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var response= _categoryReadRepository.GetAll();
            return response;
        }

        public async Task<Category> GetSingleCategoryAsync(Guid id)
        {
            var response=await _categoryReadRepository.GetByIdAsync(id);
            return response;
        }
    }
}
