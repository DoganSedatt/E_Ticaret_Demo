using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface ICategoryService
    {
        Task<Category> AddCategoryAsync(string categoryName);
        Task<List<Category>> AddRangeCategoriesAsync(IEnumerable<Category> categories);
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetSingleCategoryAsync(Guid id); 
        Task<Category> DeleteCategoryByIdAsync(Guid id);
        Task<Category> DeleteCategoryAsync(Category category);
        Task<Category> UpdateCategoryAsync(Category category);


    }
}
