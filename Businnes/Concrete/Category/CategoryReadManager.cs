using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete.Category
{
    public class CategoryReadManager : ICategoryReadService
    {
        public Task<IEnumerable<Entites.Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entites.Category> GetSingleCategoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
