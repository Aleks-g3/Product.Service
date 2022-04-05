using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Product.Service.API.Entities;
using Product.Service.Entities;
using Product.Service.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        public IProductService productService { get; }
        public IMapper mapper { get; }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="productForm"></param>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateProductFormDTO productForm)
        {
            var product = mapper.Map<ProductEntity>(productForm);
            var result = await productService.AddAsync(product);
            return Ok(result);
        }

        /// <summary>
        /// Fetches a products of list.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var product = await productService.GetAllAsync();
            return Ok(mapper.Map<IReadOnlyCollection<ProductDTO>>(product));
        }

        /// <summary>
        /// Fetches a specified product.
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await productService.GetByIdAsync(id);
            return Ok(mapper.Map<ProductEntity>(result));
        }

        /// <summary>
        /// Updates a existing product.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productFormDTO"></param>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UpdateProductFormDTO productFormDTO)
        {
            var product = mapper.Map<ProductEntity>(productFormDTO);
            await productService.UpdateAsync(id, product);
            return Ok();
        }

        /// <summary>
        /// Deletes a existing product.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await productService.DeleteAsync(id);
            return Ok();
        }
    }
}
