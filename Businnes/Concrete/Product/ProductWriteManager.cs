using Businnes.Abstract;
using DataAccess.Repository;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class ProductWriteManager : IProductWriteService
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductWriteManager(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        public async Task<Product> AddProductAsync(Product request)
        {
            Product product = new Product
            {
                ProductName = request.ProductName,
                ProductDescription = request.ProductDescription,
            };
            bool result = await _productWriteRepository.AddAsync(request);
            if (result) return product;

            return null;
        }

        public Task<List<Product>> AddRangeProductAsync(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }

        public  async Task<Product> DeleteProductAsync(Product product)
        {
            
            Product? findProduct = await _productReadRepository.GetSingleAsync(p=>p.ProductName.Contains(product.ProductName));

            var result=_productWriteRepository.DeleteWithModelAsync(findProduct);
            
            if (result) return product;

            return null;
        }

        public async Task<Product> DeleteProductByIdAsync(Guid id)
        {
            Product? findProduct=await _productReadRepository.GetByIdAsync(id);
            if(findProduct is not null)
            {
                _productWriteRepository.DeleteWithModelAsync(findProduct);
                return findProduct;
            }

            return null;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            Product? response = await _productReadRepository.GetByIdAsync(product.Id);
            if (response is not null)
            {
                response.ProductName = product.ProductName;
                response.ProductDescription = product.ProductDescription;
                _productWriteRepository.Update(response);
                return response;
            }
            return null;
        }
    }
}
