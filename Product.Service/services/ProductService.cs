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
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Guid> AddAsync(ProductEntity productEntity)
        {
            ValidationProduct(productEntity);

            var product = ProductEntity.CreateProduct(productEntity);

            await productRepository.AddAsync(product);

            return product.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await GetAsync(id);
            await productRepository.DeleteAsync(product);
        }

        public async Task<ProductEntity> GetByIdAsync(Guid id)
        {
            return await GetAsync(id);
        }

        public async Task UpdateAsync(Guid id, ProductEntity newProduct)
        {
            var product = await GetAsync(id);

            product.Update(newProduct);

            await productRepository.UpdateAsync(product);
        }

        private void ValidationProduct(ProductEntity productEntity)
        {
            if (string.IsNullOrWhiteSpace(productEntity.Name))
            {
                throw new Exception("Name is empty");
            }

            if (productEntity.Price == 0)
            {
                throw new Exception("Price is null");
            }
        }

        private async Task<ProductEntity> GetAsync(Guid id)
        {
            var product = await productRepository.GetByIdAsync(id);
            if (product == null)
            {
                throw new Exception("Not Found Product id");
            }

            return product;
        }

        public async Task<IReadOnlyCollection<ProductEntity>> GetAllAsync()
        {
            return await productRepository.GetAllAsync();
        }
    }
}
