using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service.API.Entities
{
    public class CreateProductFormDTO
    {
        [Required]
        public string Name { get; set; }
        public int Number { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
