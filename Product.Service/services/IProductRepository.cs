using Product.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.services
{
    public interface IProductRepository
    {
        Task AddAsync(ProductEntity product);
        Task UpdateAsync(ProductEntity product);
        Task<IReadOnlyCollection<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetByIdAsync(Guid id);
        Task DeleteAsync(ProductEntity product);
    }
}
