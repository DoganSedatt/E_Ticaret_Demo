using Businnes.Abstract;
using DataAccess.Repository;
using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class ProductReadManager : IProductReadService
    {
        private readonly IProductReadRepository _prodcutReadRepository;

        public ProductReadManager(IProductReadRepository prodcutReadRepository)
        {
            _prodcutReadRepository = prodcutReadRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            IEnumerable<Product> products = _prodcutReadRepository.GetAll().ToList();
            return products;
        }

        public async Task<Product> GetSingleByIdProductAsync(Guid id)
        {
            Product? product= await _prodcutReadRepository.GetByIdAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetWhereProductsAsync()
        {
            IEnumerable<Product> products = await _prodcutReadRepository.GetWhere(p=>p.ProductName.StartsWith('t')).ToListAsync();
            return products;
        }
    }
}
