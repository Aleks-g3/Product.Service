using Product.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.services
{
    public class ProductService : IProductService
    {
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IProductRepository productRepository { get; }

        public Task<Guid> AddAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, ProductEntity newProduct)
        {
            throw new NotImplementedException();
        }
    }
}
