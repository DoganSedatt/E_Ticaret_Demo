using Businnes.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete.Product
{
    public class ProductReadManager : IProductReadService
    {
        public Task<IEnumerable<Entites.Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entites.Product> GetSingleByIdProductAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entites.Product>> GetWhereProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
