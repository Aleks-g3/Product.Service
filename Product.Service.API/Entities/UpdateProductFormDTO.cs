using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service.API.Entities
{
    public class UpdateProductFormDTO
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
