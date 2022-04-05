using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service.API.Entities
{
    public class ProductDTO
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
