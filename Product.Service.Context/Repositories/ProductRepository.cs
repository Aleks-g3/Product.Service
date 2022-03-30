﻿using Microsoft.EntityFrameworkCore;
using Product.Service.Entities;
using Product.Service.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.Context.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Context context { get; }

        public ProductRepository(Context context)
        {
            this.context = context;
        }

        public async Task AddAsync(ProductEntity product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<ProductEntity>> GetAsync()
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

        public Task DeleteAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }
    }
}