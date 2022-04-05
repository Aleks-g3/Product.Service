using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        

        public static ProductEntity CreateProduct(ProductEntity product)
        {
            return new ProductEntity()
            {
                Id = new Guid(),
                Description = product.Description,
                Name = product.Name,
                Number = product.Number,
                Price = product.Price,
                Quantity = product.Quantity,
            };
        }

        public void Update(ProductEntity product)
        {
            if (Description != product.Description)
            {
                Description = product.Description;
            }

            if (Quantity != product.Quantity)
            {
                Quantity = product.Quantity;
            }
        }
    }
}
