using Businnes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete.Product
{
    public class ProductWriteManager : IProductWriteService
    {
        public Task<Entites.Product> AddCategoryAsync(Entites.Product request)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entites.Product>> AddRangeCategoriesAsync(IEnumerable<Entites.Product> categories)
        {
            throw new NotImplementedException();
        }

        public Task<Entites.Product> DeleteCategoryAsync(Entites.Product category)
        {
            throw new NotImplementedException();
        }

        public Task<Entites.Product> DeleteCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Entites.Product> UpdateCategoryAsync(Entites.Product category)
        {
            throw new NotImplementedException();
        }
    }
}
