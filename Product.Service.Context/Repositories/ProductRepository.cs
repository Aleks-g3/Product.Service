using Microsoft.EntityFrameworkCore;
using Product.Service.Entities;
using Product.Service.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Service.Context.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext context;

        public ProductRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(ProductEntity product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<ProductEntity>> GetAllAsync()
        {
            return await context.Products.ToListAsync();
        }

        public Task<ProductEntity> GetByIdAsync(Guid id)
        {
            return context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(ProductEntity product)
        {
            context.Products.Update(product);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ProductEntity product)
        {
            context.Products.Remove(product);
            await context.SaveChangesAsync();
        }
    }
}
