using Businnes.Requests.Category;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IProductWriteService
    {
        Task<Product> AddCategoryAsync(Product request);
        Task<List<Product>> AddRangeCategoriesAsync(IEnumerable<Product> categories);
        Task<Product> DeleteCategoryByIdAsync(Guid id);
        Task<Product> DeleteCategoryAsync(Product category);
        Task<Product> UpdateCategoryAsync(Product category);
    }
}
