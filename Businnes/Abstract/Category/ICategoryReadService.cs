using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes
{
    public interface ICategoryReadService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<IEnumerable<Category>> GetWhereCategoriesAsync();
        Task<Category> GetSingleByIdCategoryAsync(Guid id);
    }
}
