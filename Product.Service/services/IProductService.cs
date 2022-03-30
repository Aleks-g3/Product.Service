using Product.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.services
{
    public interface IProductService
    {
        Task<Guid> AddAsync(ProductEntity product);
        Task UpdateAsync(Guid id, ProductEntity newProduct);
        Task<ProductEntity> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
    }
}
