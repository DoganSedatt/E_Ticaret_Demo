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
        Task<Product> AddProductAsync(Product request);
        Task<List<Product>> AddRangeProductAsync(IEnumerable<Product> categories);
        Task<Product> DeleteProductByIdAsync(Guid id);
        Task<Product> DeleteProductAsync(Product category);
        Task<Product> UpdateProductAsync(Product category);
    }
}
